using BlingBackend.Logic.Interfaces;
using BlingBackend.Model;
using BlingBackeng.Data.Interface;

namespace BlingBackend.Logic
{
    public class ReminderLogic : LogicBase<Reminder>, IReminderLogic
    {
        private readonly IReminderRepository _reminderRepository;

        public ReminderLogic(IReminderRepository reminderRepository) 
            : base(reminderRepository)
        {
            _reminderRepository = reminderRepository;
        }
    }
}