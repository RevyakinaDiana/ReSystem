using NHibernate;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebLibrary;
using static System.Collections.Specialized.BitVector32;

namespace WebLibrary.Metods
{
    [Repository]
    public class UserGroupMetods
    {
        private ISession session;
        public UserGroupMetods(ISession session)
        {
            this.session = session;
        }
        public void AddGroup()
        {

        }
        public List<UserGroup> GetAll()
        {
            return session.CreateCriteria<UserGroup>().List<UserGroup>().ToList();
        }
        public void ChengeGroup()
        {

        }
        public void DeleteGroup()
        {

        }
        public void ChangeUserList()
        {

        }
    /*    public List<User> Users(long groupId)
        {
            var detach = DetachedCriteria.For<User>()
                .CreateAlias("Groups", "g", JoinType.InnerJoin)
                .Add(Restrictions.Eq("g.Id", groupId))
                .SetProjection(Projections.Id());
           return session.CreateCriteria<User>()
                .List<User>();


        }
        public UserGroupMetods(ISession session): base(session)
        {

        }*/
    }
}
