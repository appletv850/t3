using SharpDX.Direct3D11;
using T3.Core.Operator;
using T3.Core.Operator.Attributes;
using T3.Core.Operator.Slots;

namespace T3.Operators.Types.Id_2fb5aaf5_125e_4081_99ca_08918e870ec1
{
    public class MidiOutputExample : Instance<MidiOutputExample>
    {
        [Output(Guid = "6a3d1cbd-0c6e-4f2f-a626-09797b735109")]
        public readonly Slot<Texture2D> ColorBuffer = new Slot<Texture2D>();


    }
}

