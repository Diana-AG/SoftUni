namespace CarShop.Data
{
    public static class Constants
    {
        public const int IdMaxLength = 36;
        public const int DefaultMaxLength = 20;
        
        public const int UserMinUsername = 4;
        public const int UserMinPassword = 5;
        public const int UserEmailMaxLength = 100;
        public const int UserPasswordMaxLength = 64;
        public const string UserEmailRegularExpression = @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
        public const string UserTypeClient = "Client";
        public const string UserTypeMechanic = "Mechanic";

        public const int CarModelMinLength = 5;
        public const int CarPlateNumberMaxLength = 8;
        public const string CarPlateNumberRegularExpression = @"[A-Z]{2}[0-9]{4}[A-Z]{2}";
        public const int CarYearMinValue = 1900;
        public const int CarYearMaxValue = 2100;

        public const int IssueMinDescription = 5;
    }
}
