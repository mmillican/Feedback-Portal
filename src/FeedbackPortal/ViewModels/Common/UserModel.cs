﻿namespace FeedbackPortal.ViewModels.Common
{
    public class UserModel
    {
        public string Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }
        public string UserName { get; set; }

        public string FullName => FirstName + " " + LastName;
    }
}
