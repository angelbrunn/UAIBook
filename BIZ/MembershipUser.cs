using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIZ
{
    class MembershipUser
    {
      /// <summary>
      /// 
      /// </summary>
      public int Id { get; set; }
      /// <summary>
      /// 
      /// </summary>
      public String FullName { get; set; }
      /// <summary>
      /// 
      /// </summary>
      public String Password { get; set; }
      /// <summary>
      /// 
      /// </summary>
      public String PasswordSalt { get; set; }
      /// <summary>
      /// 
      /// </summary>
      public String Email { get; set; }
      /// <summary>
      /// 
      /// </summary>
      public String Avatar { get; set; }
    }
}
