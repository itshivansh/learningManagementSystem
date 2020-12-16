using System.ComponentModel.DataAnnotations.Schema;

namespace AuthenticationService.models
{
    public class User
    {
        #region Property 
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string UserId { get; set; }
        public string Password { get; set; }
        #endregion
    }
}
