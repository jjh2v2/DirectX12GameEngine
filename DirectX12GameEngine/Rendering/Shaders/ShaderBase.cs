﻿using System.Numerics;

namespace DirectX12GameEngine.Rendering.Shaders
{
    public abstract class ShaderBase
    {
        public struct VSInput
        {
            [ShaderResource] [PositionSemantic] public Vector3 Position;
            [ShaderResource] [NormalSemantic] public Vector3 Normal;
            [ShaderResource] [TangentSemantic] public Vector4 Tangent;
            [ShaderResource] [TextureCoordinateSemantic] public Vector2 TexCoord;

            [ShaderResource] [SystemInstanceIdSemantic] public uint InstanceId;
        }

        public struct PSInput
        {
            [ShaderResource] [PositionSemantic] public Vector4 PositionWS;
            [ShaderResource] [NormalSemantic(0)] public Vector3 Normal;
            [ShaderResource] [NormalSemantic(1)] public Vector3 NormalWS;
            [ShaderResource] [TangentSemantic] public Vector4 Tangent;
            [ShaderResource] [TextureCoordinateSemantic] public Vector2 TexCoord;

            [ShaderResource] [SystemPositionSemantic] public Vector4 ShadingPosition;
            [ShaderResource] [SystemInstanceIdSemantic] public uint InstanceId;
            [ShaderResource] [SystemRenderTargetArrayIndexSemantic] public uint TargetId;
        }

        public struct PSOutput
        {
            [ShaderResource] [SystemTargetSemantic] public Vector4 ColorTarget;
        }

        [Shader("vertex")]
        public virtual PSInput VSMain(VSInput input)
        {
            return default;
        }

        [Shader("pixel")]
        public virtual PSOutput PSMain(PSInput input)
        {
            return default;
        }
    }
}
