

namespace Manabank.Interface
{
    public interface IUserUpdate
    {
        public void UpdateInformation(User olduser);
        public void NextCard();
        public void PreviousCard();
    }
}
