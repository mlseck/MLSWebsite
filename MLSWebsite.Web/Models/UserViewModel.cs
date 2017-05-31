using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MLSWebsite.Core;
using System.Web.Mvc;

namespace MLSWebsite.Web.Models
{
    public class UserViewModel
    {
        public IEnumerable<user> Users;
        public SelectList userList;
        public int selectedUserId;
    }
}