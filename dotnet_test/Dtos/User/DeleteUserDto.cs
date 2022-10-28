using dotnet_test.Models;

namespace dotnet_test.Dtos.User
{
    public class DeleteUserDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Pedro";
        public string Email { get; set; } = "pedro.com";
        public int Phone { get; set; } = 1234;
        public UserType Type { get; set; }
    }
}
