namespace Paper.Models.EndpointModels
{
    public class NewUser
    {
        public string Email { get; set; }

        public bool AcceptedTermsAndConditions { get; set; }

        public bool RegistrationDate { get; set; }

        public string Country { get; set; }
    }
}
