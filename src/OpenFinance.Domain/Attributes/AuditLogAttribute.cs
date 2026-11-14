namespace OpenFinance.Domain.Attributes;


/// <summary>
/// Usar em Classes de entidades que terão suas alterações de Create, Update e Delete auditadas
/// </summary>
[AttributeUsage(AttributeTargets.Class)]
public class AuditLogAttribute : Attribute
{
    public bool Create { get; set; } = false;
    public bool Update { get; set; } = false;
    public bool Delete { get; set; } = false;
}
