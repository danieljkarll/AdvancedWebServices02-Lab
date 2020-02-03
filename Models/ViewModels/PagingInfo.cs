using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modas.Models.ViewModels
{
    public class PagingInfo
    {
        public int ItemsPerPage { get; set; }
        public int TotalItems { get; set; }
        public int CurrentPage { get; set; }

        public int TotalPages()
        {
            return (int)Math.Ceiling((decimal)(TotalItems / ItemsPerPage));
        }

        public int NextPage()
        {
            if (CurrentPage == TotalPages())
            {
                return CurrentPage;
            }
            else {
                return CurrentPage + 1;

            }
        }
        public int PreviousPage()
        {
            if (CurrentPage == 1)
            {
                return CurrentPage;
            }
            else
            {
                return CurrentPage - 1;

            }
        }

        public int Ranges()
        {
            return (CurrentPage - 1) * ItemsPerPage + 1;
        }
        public int EndRange()
        {
            if (CurrentPage == TotalPages())
            {
                return TotalItems;
            }
            else
            {
                return Ranges() + ItemsPerPage + 1;
            }
        }
    }
}
