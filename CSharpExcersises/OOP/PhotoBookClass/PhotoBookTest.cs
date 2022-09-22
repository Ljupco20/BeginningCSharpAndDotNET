using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoBookClass
{
    internal class PhotoBookTest
    {
        public void ShowBooks()
        {
            PhotoBook photoBook16 = new PhotoBook();
            PhotoBook photoBook24 = new PhotoBook(24);
            BigPhotoBook bigPhotoBook = new BigPhotoBook();

            Console.WriteLine(photoBook16.GetNumberPages());
            Console.WriteLine(photoBook24.GetNumberPages());
            Console.WriteLine(bigPhotoBook.GetNumberPages());
        }
       

    }
}
