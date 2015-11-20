using BlingBackend.Logic.Interfaces;
using BlingBackend.Model;
using BlingBackeng.Data.Interface;

namespace BlingBackend.Logic
{
    public class GroupLogic : LogicBase<Group>, IGroupLogic
    {
        private readonly IGroupRepository _groupRepository;

        public GroupLogic(IGroupRepository groupRepository) 
            : base(groupRepository)
        {
            _groupRepository = groupRepository;
        }
    }
}