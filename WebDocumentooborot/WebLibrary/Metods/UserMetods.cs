using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebLibrary.Metods
{
    [Repository]
        public class UserMetods
        {
        private ISession session;
        public UserMetods(ISession session)
        {
            this.session = session;
        }
            public void AddUser(User user)
            {

            }
            public void ChengeUser()
            {

            }
            public void SelectByStatus()
            {

            }
        public List<User> GetAll()
        {
            return session.CreateCriteria<User>().List<User>().ToList();
        }
        public void Save(User user)
        {
            using (var tr = session.BeginTransaction())
            {
                session.Save(user);
                tr.Commit();
            }
        }

            public void GenerateSol()
            {

            }
        public User Load(long id)
        {
            return session.Load<User>(id);
        }
        }
    }

