#if !EXCLUDE_CODEGEN
#pragma warning disable 162
#pragma warning disable 219
#pragma warning disable 414
#pragma warning disable 649
#pragma warning disable 693
#pragma warning disable 1591
#pragma warning disable 1998
[assembly: global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0")]
[assembly: global::Orleans.CodeGeneration.OrleansCodeGenerationTargetAttribute("Footban.Account, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")]
namespace Footban.Account.Model.State
{
    using global::Orleans.Async;
    using global::Orleans;
    using global::System.Reflection;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Footban.Account.Model.State.PlayerState)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenFootban_Account_Model_State_PlayerStateSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Footban.Account.Model.State.PlayerState input = ((global::Footban.Account.Model.State.PlayerState)original);
            global::Footban.Account.Model.State.PlayerState result = new global::Footban.Account.Model.State.PlayerState();
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            result.@Level = input.@Level;
            result.@PlayerId = input.@PlayerId;
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Footban.Account.Model.State.PlayerState input = (global::Footban.Account.Model.State.PlayerState)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Level, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@PlayerId, stream, typeof (global::System.Int32));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Footban.Account.Model.State.PlayerState result = new global::Footban.Account.Model.State.PlayerState();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            result.@Level = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            result.@PlayerId = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            return (global::Footban.Account.Model.State.PlayerState)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Footban.Account.Model.State.PlayerState), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenFootban_Account_Model_State_PlayerStateSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Footban.Account.Model.Streams.MatchMakingPayload)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenFootban_Account_Model_Streams_MatchMakingPayloadSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Footban.Account.Model.Streams.MatchMakingPayload input = ((global::Footban.Account.Model.Streams.MatchMakingPayload)original);
            global::Footban.Account.Model.Streams.MatchMakingPayload result = new global::Footban.Account.Model.Streams.MatchMakingPayload();
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Footban.Account.Model.Streams.MatchMakingPayload input = (global::Footban.Account.Model.Streams.MatchMakingPayload)untypedInput;
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Footban.Account.Model.Streams.MatchMakingPayload result = new global::Footban.Account.Model.Streams.MatchMakingPayload();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            return (global::Footban.Account.Model.Streams.MatchMakingPayload)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Footban.Account.Model.Streams.MatchMakingPayload), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenFootban_Account_Model_Streams_MatchMakingPayloadSerializer()
        {
            Register();
        }
    }
}
#pragma warning restore 162
#pragma warning restore 219
#pragma warning restore 414
#pragma warning restore 649
#pragma warning restore 693
#pragma warning restore 1591
#pragma warning restore 1998
#endif
