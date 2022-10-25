using FLASHBACKS.Models;
using System.Collections.Generic;

namespace FLASHBACKS.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }

}
