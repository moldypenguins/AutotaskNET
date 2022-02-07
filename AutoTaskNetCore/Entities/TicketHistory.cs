using net.autotask.webservices;

namespace AutotaskNET.Entities
{
    public class TicketHistory : Entity
    {
        public override bool CanCreate => false;
        public override bool CanUpdate => false;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;
        
        
        public TicketHistory() : base() { } //end Task()
        public TicketHistory(net.autotask.webservices.TicketHistory entity) : base(entity)
        {

        } //end Task(net.autotask.webservices.Task entity)

        public static implicit operator net.autotask.webservices.TicketHistory(TicketHistory entity)
        {
            return new net.autotask.webservices.TicketHistory()
            {
                id = entity.id,
            };

        } //end implicit operator net.autotask.webservices.Task(Task task)


    }
}