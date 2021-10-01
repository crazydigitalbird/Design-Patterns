using System;

namespace ProxyCRUD
{
    class Proxy: Subject
    {
        private Subject subject;
        private Role role;

        public Proxy(Subject subject, Role role)
        {
            this.subject = subject;
            this.role = role;
        }

        public override void Create(string key, string value)
        {
            if(role == Role.Owner)
            {
                subject.Create(key, value);
            }
            else
            {
                throw new UnauthorizedAccessException("Create: Access denied.");
            }
        }

        public override string Read(string key)
        {
            return subject.Read(key);
        }

        public override bool Update(string key, string value)
        {
            if(role != Role.User)
            {
                return subject.Update(key, value);
            }
            else
            {
                throw new UnauthorizedAccessException("Update: Access denied.");
            }
        }

        public override bool Delete(string key)
        {
            if(role == Role.Owner || role == Role.Administrator)
            {
                return subject.Delete(key);
            }
            else
            {
                throw new UnauthorizedAccessException("Delete: Access denied.");
            }
        }
    }
}
