// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: vehicle_model_config.proto
// </auto-generated>

#pragma warning disable 0612, 1591, 3021
namespace apollo.common
{

    [global::ProtoBuf.ProtoContract()]
    public partial class VehicleModelConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public VehicleModelConfig()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(ModelType.REAR_CENTERED_KINEMATIC_BICYCLE_MODEL)]
        public ModelType model_type
        {
            get { return __pbn__model_type ?? ModelType.REAR_CENTERED_KINEMATIC_BICYCLE_MODEL; }
            set { __pbn__model_type = value; }
        }
        public bool ShouldSerializemodel_type()
        {
            return __pbn__model_type != null;
        }
        public void Resetmodel_type()
        {
            __pbn__model_type = null;
        }
        private ModelType? __pbn__model_type;

        [global::ProtoBuf.ProtoMember(2)]
        public RearCenteredKinematicBicycleModelConfig rc_kinematic_bicycle_model { get; set; }

        [global::ProtoBuf.ProtoMember(3)]
        public ComCenteredDynamicBicycleModelConfig comc_dynamic_bicycle_model { get; set; }

        [global::ProtoBuf.ProtoMember(4)]
        public MlpModelConfig mlp_model { get; set; }

        [global::ProtoBuf.ProtoContract()]
        public enum ModelType
        {
            REAR_CENTERED_KINEMATIC_BICYCLE_MODEL = 0,
            COM_CENTERED_DYNAMIC_BICYCLE_MODEL = 1,
            MLP_MODEL = 2,
        }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class RearCenteredKinematicBicycleModelConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public RearCenteredKinematicBicycleModelConfig()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public double dt
        {
            get { return __pbn__dt.GetValueOrDefault(); }
            set { __pbn__dt = value; }
        }
        public bool ShouldSerializedt()
        {
            return __pbn__dt != null;
        }
        public void Resetdt()
        {
            __pbn__dt = null;
        }
        private double? __pbn__dt;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ComCenteredDynamicBicycleModelConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public ComCenteredDynamicBicycleModelConfig()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public double dt
        {
            get { return __pbn__dt.GetValueOrDefault(); }
            set { __pbn__dt = value; }
        }
        public bool ShouldSerializedt()
        {
            return __pbn__dt != null;
        }
        public void Resetdt()
        {
            __pbn__dt = null;
        }
        private double? __pbn__dt;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MlpModelConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public MlpModelConfig()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public double dt
        {
            get { return __pbn__dt.GetValueOrDefault(); }
            set { __pbn__dt = value; }
        }
        public bool ShouldSerializedt()
        {
            return __pbn__dt != null;
        }
        public void Resetdt()
        {
            __pbn__dt = null;
        }
        private double? __pbn__dt;

    }

}

#pragma warning restore 0612, 1591, 3021