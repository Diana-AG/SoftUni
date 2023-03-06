namespace FootballManager.Data
{
    public static class DataConstants
    {
        public const int IdMaxLength = 40;
        public const int UserUsernameMinLength = 5;
        public const int UserUsernameMaxLength = 20;
        public const int UserEmailMinLength = 10;
        public const int UserEmailMaxLength = 60;
        public const int UserPasswordMinLength = 5;
        public const int UserPasswordMaxLength = 20;
        public const int UserPasswordDbMaxLength = 64;
        public const string UserEmailRegularExpression = @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";

        public const int PlayerFullNamelMinLength = 5;
        public const int PlayerFullNameMaxLength = 80;
        public const int PlayerPositionMinLength = 5;
        public const int PlayerPositionMaxLength = 20;
        public const int PlayerSpeedMinLength = 0;
        public const int PlayerSpeedMaxLength = 10;
        public const int PlayerEnduranceMinLength = 0;
        public const int PlayerEnduranceMaxLength = 10;
        public const int PlayerDescriptionMaxLength = 200;
    }
}
