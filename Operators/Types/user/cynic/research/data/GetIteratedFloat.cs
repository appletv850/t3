using System.Reflection;
using T3.Core.DataTypes;
using T3.Core.Operator;
using T3.Core.Operator.Attributes;
using T3.Core.Operator.Slots;
using T3.Core.Utils;

namespace T3.Operators.Types.Id_f83bd8ce_ca66_4d31_9f2f_65066f15a3b2
{
    public class GetIteratedFloat : Instance<GetIteratedFloat>
    {
        [Output(Guid = "1170f76f-b438-4b1d-b329-ee07b950f291", DirtyFlagTrigger = DirtyFlagTrigger.Animated)]
        public readonly Slot<float> Result = new Slot<float>();

        public GetIteratedFloat()
        {
            Result.UpdateAction = Update;
            Result.DirtyFlag.Trigger |= DirtyFlagTrigger.Animated;
        }

        private void Update(EvaluationContext context)
        {
            Result.Value = StructuredListUtils.GetIteratedValueOfFieldWithType<float>(context, FieldName, ref _field);
        }

        private FieldInfo _field;

        [Input(Guid = "d09ec35b-6f02-424f-87cf-51c0c9f56857")]
        public readonly InputSlot<string> FieldName = new InputSlot<string>();
    }
}