namespace Swashbuckle.AspNetCore.SwaggerGen.Test
{
#nullable enable
    public class FakeControllerWithNullableReferenceTypes
    {
        public void ActionWithNonNullableReferenceTypeParameter(string param)
        { }

        public void ActionWithNullableReferenceTypeParameter(string? param)
        { }

        public void ActionWithNullableParameter(int? param)
        { }

        public void ActionWithNonNullableParameter(int param)
        { }
    }
#nullable disable
}