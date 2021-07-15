using Api.Core.Domain;
using Api.Data.Context;

namespace Api.Service
{
    public class MemberService : Repository<MasterMember>, IMemberService
    {
        public MemberService(ApiContext context) : base(context)
        {

        }
    }
}
