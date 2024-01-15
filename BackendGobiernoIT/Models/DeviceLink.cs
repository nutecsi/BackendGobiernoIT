namespace BackendGobiernoIT.Models;

public class DeviceLink
{
    public int SourceDeviceId {  get; set; }
    public int DestinationDeviceId { get; set; }
    
    public virtual Device SourceDevice { get; set; }
    public virtual Device DestinationDevice { get; set; }
}
