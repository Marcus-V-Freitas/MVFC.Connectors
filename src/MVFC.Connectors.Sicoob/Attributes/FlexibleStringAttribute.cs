namespace MVFC.Connectors.Sicoob.Attributes;

[AttributeUsage(AttributeTargets.Property)]
internal sealed class FlexibleStringAttribute() : JsonConverterAttribute(typeof(FlexibleStringConverter))
{
}