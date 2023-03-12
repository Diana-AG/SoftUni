namespace SMS.Data
{
    public static class DataConstants
    {
        public const int IdMaxLength = 40;

        public const int UserUsernameMinLength = 5;
        public const int UserUsernameMaxLength = 20;
        public const int UserPasswordMinLength = 6;
        public const int UserPasswordMaxLength = 20;
        public const int UserPasswordHashMaxLength = 100;
        public const int UserEmailMaxLength = 100;
        public const string UserEmailRegularExpression = @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
        
        public const int ProductNameMinLength = 4;
        public const int ProductNameMaxLength = 20;
        public const decimal ProductPriceMin = 0.05M;
        public const decimal ProductPriceMax = 1000M;
    }
}
