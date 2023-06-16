namespace UserManagementWithIdentity.ViewModels
{
    public class EditUserViewModel
    {
        public string Id { get; set; }

        [Required, MaxLength(50)]
        [Display(Name = "FirstName")]
        public string FirstName { get; set; }

        [Required, MaxLength(50)]
        [Display(Name = "LastName")]
        public string LastName { get; set; }

        [Required, MaxLength(50)]
        [Display(Name = "UserName")]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }



    }
}
