namespace BackendGobiernoIT.Models;

public class BackupDeviceLink
{
    public int BackupId { get; set; }
    public int DeviceId { get; set; }

    public virtual Backup Backup { get; set; }
    public virtual Device Device { get; set; }
}
