using Activities.Domain.Entities;

namespace Activities.Service.Interface
{
    public interface IJwtGenerator
    {
        string CreateToken(AppUser user);
    }
}
