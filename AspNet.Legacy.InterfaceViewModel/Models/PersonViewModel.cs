namespace AspNet.Legacy.InterfaceViewModel.Models
{
    public class PersonViewModel : IAnimalViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public AddressViewModel Address { get; set; }
    }
}