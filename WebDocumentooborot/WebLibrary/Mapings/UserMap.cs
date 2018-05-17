using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebLibrary.Mapings
{
  public  class UserMap: ClassMap<User>
    {
        public UserMap()
        {
            Id(u => u.UserId);
            Map(u => u.login).Length(30);
            Map(u => u.password).Column("PasswordHash");
            Map(u => u.name).Length(20);
            Map(u => u.surname).Length(30);
            Map(u => u.Sol).Length(30);
            Map(u => u.patronymic).Length(20);
            Map(u => u.Email).Length(30);
            Map(u => u.DateBirth);
            Map(u => u.Status).Length(30);
            References(u => u.Avatar);
            
                
        }

       
    }
}
