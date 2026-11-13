namespace OpenFinance.Domain.Attributes;

/// <summary>
/// Usar em atributos de entidades que não são persistidos
/// Ou seja, atributos estão na classe mas não compõem a tabela do banco de dados
/// </summary>
[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
public class TransienteAttribute : Attribute { }
