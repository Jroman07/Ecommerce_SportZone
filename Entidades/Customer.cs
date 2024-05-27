namespace Entidades
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; private set; }

        public Customer() { IsActive = true; }

        public void ChangeIsActive() { IsActive = false; }
    }
}
