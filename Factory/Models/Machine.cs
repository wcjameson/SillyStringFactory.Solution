using System.Collections.Generic;

namespace SillyStringFactory.Models
{
  public class Machine
  {
    public Machine()
    {
      this.JoinEntities = new HashSet<MachineEngineer>();
    }
    public int MachineId {get; set; }
    public string Description { get; set; }
    public virtual ICollection<MachineEngineer> JoinEntities { get; set; }
  }
}