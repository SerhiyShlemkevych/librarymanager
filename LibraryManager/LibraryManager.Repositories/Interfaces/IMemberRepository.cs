using LibraryManager.Entities;
using System.Collections.Generic;

namespace LibraryManager.Repositories
{
    public interface IMemberRepository
    {
        IEnumerable<Member> SelectMembers(string filterName, string FilterValue);
        IEnumerable<MemberIdInfo> SelectMembersIdInfo(string filterName, string FilterValue); 
        void AddMember(Member memberToAdd);
        void EditMember(Member memverToEdit, string passport);
        Member GetMemberByPassport(string passport);
        MemberId GetMemberIdByPassport(string passport);
        
    }
}
