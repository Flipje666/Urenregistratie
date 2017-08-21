using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace UrenregistratieService
{
    public class UrenregistratieService : IUrenregistratieService
    {
        

//      Functie om een nieuwe gebruiker te registreren, deze wordt aan het standaard project toegekend.
        public bool Register(string username)
        {
            var chararray = username.ToCharArray();
            Array.Reverse(chararray);
            var password = new string(chararray);
            var regUser = new AppUser()
            {
                Password = password,
                Username = username,
                Project = null,
            };
            var defaultTasks = new List<Task>(5)
            {
                new Task() { Hours = 0, Name = "Programmeren", AppUser = regUser },
                new Task() { Hours = 0, Name = "Ontwerpen", AppUser = regUser },
                new Task() { Hours = 0, Name = "Adviseren", AppUser = regUser },
                new Task() { Hours = 0, Name = "Deskundigheid", AppUser = regUser },
                new Task() { Hours = 0, Name = "Overig", AppUser = regUser }
            };
            using (var ctx = new UrenregistratieDBModelContainer())
            {
                var dbuser = ctx.AppUsers.SingleOrDefault(dbu => dbu.Username.Equals(regUser.Username));
                if (dbuser == null)
                {
                    regUser.Project = ctx.Projects.Find(1);
                    ctx.Tasks.AddRange(defaultTasks);
                    ctx.AppUsers.Add(regUser);
                    ctx.SaveChanges();
                    return true;
                }
                if (dbuser.Username.Equals(regUser.Username))
                {
                    return false;
                }
            }
            return false;
        }

//      Functie om in te loggen als bestaande gebruiker.
        public bool Login(string username, string password)
        {
            using (var ctx = new UrenregistratieDBModelContainer())
            {
                var dbUser = ctx.AppUsers.SingleOrDefault(u => u.Username.Equals(username) &&
                                                       u.Password.Equals(password));
                return dbUser != null && dbUser.Username.Equals(username);
            }
        }

//      Functie om een gebruiker op te halen, voornamelijk voor het bijhouden van de ingelogde gebruiker.
        public AppUser GetUser(string username, string password)
        {
            if (!Login(username, password)) return null;
            using (var ctx = new UrenregistratieDBModelContainer())
            {
                var dbUser = ctx.AppUsers.SingleOrDefault(u => u.Username.Equals(username) &&
                                                            u.Password.Equals(password));
                if (dbUser != null)
                    return new AppUser()
                    {
                        Userid = dbUser.Userid,
                        Username = dbUser.Username,
                        Password = dbUser.Password,
                        Project = dbUser.Project
                    };
            }
            return null;
        }

//      Haalt een lijst met taken op van de ingelogde gebruiker, aangezien de gebruiker geen verwijzing heeft naar zijn taken maar andersom wel.
        public List<Task> GetUserTasks(AppUser user)
        {
            if (!Login(user.Username, user.Password)) return null;
            using (var ctx = new UrenregistratieDBModelContainer())
            {

                var dbUserTasks = from task in ctx.Tasks where task.AppUser.Userid == user.Userid select task;
                var userTasks = new List<Task>(5);
                foreach (var t in dbUserTasks)
                {
                    userTasks.Add(new Task() {Name = t.Name, Taskid = t.Taskid, Hours = t.Hours});
                }
                return userTasks;
            }
        }
        

//        Functie voor het toevoegen van gewerkte uren.
        public AppUser SaveHours(string task, int hours, AppUser u)
        {
            if (!Login(u.Username, u.Password)) return null;
            using (var ctx = new UrenregistratieDBModelContainer())
            {
                var userTask = ctx.Tasks.SingleOrDefault(t => t.Name == task && t.AppUser.Userid.Equals(u.Userid));

                if (userTask == null) return null;
                userTask.Hours += hours;
                ctx.SaveChanges();

                return u;
            }
        }

//        Functie voor het aanpassen van het totaal aantal gewerkte uren.
        public AppUser EditHours(string task, int hours, AppUser u)
        {
            if (!Login(u.Username, u.Password)) return null;
            using (var ctx = new UrenregistratieDBModelContainer())
            {
                var userTask = ctx.Tasks.SingleOrDefault(t => t.Name == task && t.AppUser.Userid.Equals(u.Userid));

                if (userTask == null) return null;
                userTask.Hours = hours;
                ctx.SaveChanges();

                return u;
            }

        }

//        Functie om gewerkte uren voor een taak op nul te zetten.
        public AppUser DeleteHours(string task, AppUser u)
        {
            if (!Login(u.Username, u.Password)) return null;
            using (var ctx = new UrenregistratieDBModelContainer())
            {
                var userTask = ctx.Tasks.SingleOrDefault(t => t.Name == task && t.AppUser.Userid.Equals(u.Userid));

                if (userTask == null) return null;
                userTask.Hours = 0;
                ctx.SaveChanges();

                return u;
            }
        }


    }
}
