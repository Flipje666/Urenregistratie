using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace UrenregistratieService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IUrenregistratieService" in both code and config file together.
    [ServiceContract]
    public interface IUrenregistratieService
    {
        [OperationContract]
        bool Register(string username);

        [OperationContract]
        bool Login(string username, string password);

        [OperationContract]
        AppUser GetUser(string username, string password);

        [OperationContract]
        List<Task> GetUserTasks(AppUser user);

        [OperationContract]
        AppUser SaveHours(string task, int hours, AppUser u);

        [OperationContract]
        AppUser EditHours(string task, int hours, AppUser u);

        [OperationContract]
        AppUser DeleteHours(string task, AppUser u);
    }
}
