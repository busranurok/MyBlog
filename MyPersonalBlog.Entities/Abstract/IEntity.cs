using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPersonalBlog.Entities.Abstract
{
    public interface IEntity
    {
        //NOT: Bütün class ların ortak propertyleri buraya yazılır
        //NOT: Bütün class ların hepsini tek bir çatı altında toplamak için, hepsini aynı soyad altında toplamak gibi
        //bu da bize IEntityRepository de kolaylık sağlayacak
    }
}
