// Shader created with Shader Forge v1.32 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.32;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:0,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:0,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:True,fnsp:False,fnfb:False;n:type:ShaderForge.SFN_Final,id:3138,x:34667,y:32707,varname:node_3138,prsc:2|normal-8361-OUT,emission-7186-OUT,custl-6638-OUT;n:type:ShaderForge.SFN_Color,id:7241,x:32823,y:32317,ptovrint:False,ptlb:Color1,ptin:_Color1,varname:node_7241,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.07843138,c2:0.3921569,c3:0.7843137,c4:1;n:type:ShaderForge.SFN_Lerp,id:6174,x:33144,y:32447,varname:node_6174,prsc:2|A-7241-RGB,B-2891-RGB,T-239-RGB;n:type:ShaderForge.SFN_Color,id:2891,x:32823,y:32485,ptovrint:False,ptlb:Color2,ptin:_Color2,varname:_Color_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.05758001,c2:0.264015,c3:0.5220588,c4:1;n:type:ShaderForge.SFN_FragmentPosition,id:7053,x:32531,y:32102,varname:node_7053,prsc:2;n:type:ShaderForge.SFN_Distance,id:5508,x:32755,y:32055,varname:node_5508,prsc:2|A-7053-XYZ,B-4608-XYZ;n:type:ShaderForge.SFN_Divide,id:7754,x:32962,y:32055,varname:node_7754,prsc:2|A-5508-OUT,B-7184-OUT;n:type:ShaderForge.SFN_ValueProperty,id:7184,x:32962,y:31986,ptovrint:False,ptlb:Dist,ptin:_Dist,varname:node_7184,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:50;n:type:ShaderForge.SFN_Lerp,id:7186,x:34178,y:32644,varname:node_7186,prsc:2|A-5917-OUT,B-2807-RGB,T-2978-OUT;n:type:ShaderForge.SFN_Color,id:2807,x:33770,y:32709,ptovrint:False,ptlb:Color_Fade,ptin:_Color_Fade,varname:node_2807,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0,c2:1,c3:0.2965517,c4:1;n:type:ShaderForge.SFN_Posterize,id:2978,x:33173,y:32055,varname:node_2978,prsc:2|IN-7754-OUT,STPS-9161-OUT;n:type:ShaderForge.SFN_ValueProperty,id:9161,x:33173,y:31986,ptovrint:False,ptlb:PosterizeDist,ptin:_PosterizeDist,varname:node_9161,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:3;n:type:ShaderForge.SFN_ViewPosition,id:4608,x:32531,y:31965,varname:node_4608,prsc:2;n:type:ShaderForge.SFN_Time,id:3824,x:30430,y:32655,varname:node_3824,prsc:2;n:type:ShaderForge.SFN_NormalVector,id:8048,x:32894,y:33417,prsc:2,pt:True;n:type:ShaderForge.SFN_LightVector,id:6963,x:32894,y:33578,varname:node_6963,prsc:2;n:type:ShaderForge.SFN_ViewReflectionVector,id:5543,x:32894,y:33710,varname:node_5543,prsc:2;n:type:ShaderForge.SFN_Tex2d,id:4893,x:32911,y:33115,varname:node_4893,prsc:2,tex:10d3ad68aeb85314c838df8c2ccf4c05,ntxv:3,isnm:True|UVIN-1640-OUT,TEX-4520-TEX;n:type:ShaderForge.SFN_Dot,id:1818,x:33221,y:33476,varname:node_1818,prsc:2,dt:1|A-8048-OUT,B-6963-OUT;n:type:ShaderForge.SFN_Dot,id:7031,x:33202,y:33643,varname:node_7031,prsc:2,dt:1|A-6963-OUT,B-5543-OUT;n:type:ShaderForge.SFN_Multiply,id:4178,x:33936,y:33485,varname:node_4178,prsc:2|A-1818-OUT,B-7648-OUT;n:type:ShaderForge.SFN_Slider,id:6417,x:32784,y:33874,ptovrint:False,ptlb:Glossiness,ptin:_Glossiness,varname:node_6417,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:1,cur:1,max:12;n:type:ShaderForge.SFN_Exp,id:2879,x:33134,y:33874,varname:node_2879,prsc:2,et:0|IN-6417-OUT;n:type:ShaderForge.SFN_Power,id:2744,x:33477,y:33655,varname:node_2744,prsc:2|VAL-7031-OUT,EXP-2879-OUT;n:type:ShaderForge.SFN_Posterize,id:6638,x:34174,y:33485,varname:node_6638,prsc:2|IN-4178-OUT,STPS-7863-OUT;n:type:ShaderForge.SFN_ValueProperty,id:7863,x:34174,y:33649,ptovrint:False,ptlb:PosterizeLight,ptin:_PosterizeLight,varname:node_7863,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:10;n:type:ShaderForge.SFN_Tex2d,id:239,x:32823,y:32644,varname:node_239,prsc:2,tex:271e3f0231ab1744fb9106a87a61e131,ntxv:0,isnm:False|UVIN-1640-OUT,TEX-7604-TEX;n:type:ShaderForge.SFN_Tex2dAsset,id:4520,x:30430,y:33005,ptovrint:False,ptlb:Normal,ptin:_Normal,varname:node_4520,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:10d3ad68aeb85314c838df8c2ccf4c05,ntxv:3,isnm:True;n:type:ShaderForge.SFN_Tex2d,id:3571,x:32911,y:33241,varname:node_3571,prsc:2,tex:10d3ad68aeb85314c838df8c2ccf4c05,ntxv:0,isnm:False|UVIN-7868-OUT,TEX-4520-TEX;n:type:ShaderForge.SFN_NormalBlend,id:9535,x:33363,y:33114,varname:node_9535,prsc:2|BSE-4893-RGB,DTL-3571-RGB;n:type:ShaderForge.SFN_Color,id:2337,x:33477,y:33797,ptovrint:False,ptlb:Glossiness_Color,ptin:_Glossiness_Color,varname:node_2337,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:0,c3:0,c4:1;n:type:ShaderForge.SFN_Multiply,id:7648,x:33720,y:33655,varname:node_7648,prsc:2|A-2744-OUT,B-2337-RGB;n:type:ShaderForge.SFN_Tex2d,id:3295,x:31438,y:33444,varname:node_3295,prsc:2,tex:28c7aad1372ff114b90d330f8a2dd938,ntxv:0,isnm:False|UVIN-7868-OUT,TEX-8722-TEX;n:type:ShaderForge.SFN_Slider,id:1045,x:31281,y:33655,ptovrint:False,ptlb:Remap,ptin:_Remap,varname:node_1045,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Add,id:3856,x:31864,y:33478,varname:node_3856,prsc:2|A-4659-OUT,B-1045-OUT;n:type:ShaderForge.SFN_RemapRange,id:3731,x:32055,y:33515,varname:node_3731,prsc:2,frmn:0,frmx:1,tomn:-2,tomx:1|IN-3856-OUT;n:type:ShaderForge.SFN_Tex2dAsset,id:8722,x:30430,y:33194,ptovrint:False,ptlb:ReampTexture,ptin:_ReampTexture,varname:node_8722,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:28c7aad1372ff114b90d330f8a2dd938,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:9142,x:31449,y:33264,varname:node_9142,prsc:2,tex:28c7aad1372ff114b90d330f8a2dd938,ntxv:0,isnm:False|UVIN-1640-OUT,TEX-8722-TEX;n:type:ShaderForge.SFN_Multiply,id:4659,x:31669,y:33401,varname:node_4659,prsc:2|A-3295-RGB,B-9142-RGB;n:type:ShaderForge.SFN_NormalBlend,id:8361,x:33689,y:33068,varname:node_8361,prsc:2|BSE-9535-OUT,DTL-3731-OUT;n:type:ShaderForge.SFN_Tex2dAsset,id:7604,x:30430,y:32825,ptovrint:False,ptlb:Diffuse,ptin:_Diffuse,varname:node_7604,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:271e3f0231ab1744fb9106a87a61e131,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:2561,x:32823,y:32786,varname:node_2561,prsc:2,tex:271e3f0231ab1744fb9106a87a61e131,ntxv:0,isnm:False|UVIN-7868-OUT,TEX-7604-TEX;n:type:ShaderForge.SFN_Color,id:233,x:32823,y:32952,ptovrint:False,ptlb:Color3,ptin:_Color3,varname:node_233,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:0,c3:0,c4:1;n:type:ShaderForge.SFN_OneMinus,id:8287,x:33052,y:32786,varname:node_8287,prsc:2|IN-2561-RGB;n:type:ShaderForge.SFN_Lerp,id:5917,x:33515,y:32544,varname:node_5917,prsc:2|A-233-RGB,B-6174-OUT,T-8287-OUT;n:type:ShaderForge.SFN_Multiply,id:7042,x:31408,y:32395,varname:node_7042,prsc:2|A-3824-T,B-4698-OUT,C-2308-OUT;n:type:ShaderForge.SFN_Add,id:1640,x:31649,y:32395,varname:node_1640,prsc:2|A-7042-OUT,B-3714-OUT;n:type:ShaderForge.SFN_Slider,id:2308,x:30957,y:32474,ptovrint:False,ptlb:DiffuseBack_Speed,ptin:_DiffuseBack_Speed,varname:node_8556,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.424354,max:1;n:type:ShaderForge.SFN_TexCoord,id:326,x:30430,y:32497,varname:node_326,prsc:2,uv:0;n:type:ShaderForge.SFN_ValueProperty,id:7063,x:30850,y:32269,ptovrint:False,ptlb:DiffuseBack_U_Directon,ptin:_DiffuseBack_U_Directon,varname:node_1406,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_ValueProperty,id:7866,x:30850,y:32347,ptovrint:False,ptlb:DiffuseBack_V_Direction,ptin:_DiffuseBack_V_Direction,varname:node_8995,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Append,id:4698,x:31095,y:32286,varname:node_4698,prsc:2|A-7063-OUT,B-7866-OUT;n:type:ShaderForge.SFN_Multiply,id:8910,x:31460,y:32708,varname:node_8910,prsc:2|A-1102-OUT,B-4214-OUT,C-3824-T;n:type:ShaderForge.SFN_Add,id:7868,x:31673,y:32557,varname:node_7868,prsc:2|A-8910-OUT,B-3714-OUT;n:type:ShaderForge.SFN_Append,id:1102,x:31146,y:32623,varname:node_1102,prsc:2|A-6083-OUT,B-2393-OUT;n:type:ShaderForge.SFN_ValueProperty,id:6083,x:30857,y:32620,ptovrint:False,ptlb:DiffuseFront_U_Direction,ptin:_DiffuseFront_U_Direction,varname:node_6083,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_ValueProperty,id:2393,x:30857,y:32700,ptovrint:False,ptlb:DiffuseFront_V_Direction,ptin:_DiffuseFront_V_Direction,varname:node_2393,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:-1;n:type:ShaderForge.SFN_Slider,id:4214,x:30989,y:32859,ptovrint:False,ptlb:DiffuseFront_Speed,ptin:_DiffuseFront_Speed,varname:node_4214,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.4957202,max:1;n:type:ShaderForge.SFN_Tex2d,id:8723,x:30241,y:32063,varname:node_8723,prsc:2,tex:28c7aad1372ff114b90d330f8a2dd938,ntxv:0,isnm:False|TEX-8722-TEX;n:type:ShaderForge.SFN_Lerp,id:3714,x:31400,y:32039,varname:node_3714,prsc:2|A-4974-OUT,B-326-UVOUT,T-343-OUT;n:type:ShaderForge.SFN_Slider,id:343,x:30531,y:32144,ptovrint:False,ptlb:distort,ptin:_distort,varname:node_343,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_RemapRange,id:4974,x:30989,y:31918,varname:node_4974,prsc:2,frmn:0,frmx:1,tomn:-1,tomx:1|IN-2499-OUT;n:type:ShaderForge.SFN_Add,id:2499,x:30781,y:31918,varname:node_2499,prsc:2|A-8723-RGB,B-5598-OUT;n:type:ShaderForge.SFN_Slider,id:5598,x:30312,y:31944,ptovrint:False,ptlb:RemapDistort,ptin:_RemapDistort,varname:node_5598,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.5095199,max:1;proporder:7604-7241-2891-233-6083-2393-4214-7063-7866-2308-4520-8722-1045-2807-7184-9161-2337-6417-7863-343-5598;pass:END;sub:END;*/

Shader "Shader Forge/water" {
    Properties {
        _Diffuse ("Diffuse", 2D) = "white" {}
        _Color1 ("Color1", Color) = (0.07843138,0.3921569,0.7843137,1)
        _Color2 ("Color2", Color) = (0.05758001,0.264015,0.5220588,1)
        _Color3 ("Color3", Color) = (1,0,0,1)
        _DiffuseFront_U_Direction ("DiffuseFront_U_Direction", Float ) = 1
        _DiffuseFront_V_Direction ("DiffuseFront_V_Direction", Float ) = -1
        _DiffuseFront_Speed ("DiffuseFront_Speed", Range(0, 1)) = 0.4957202
        _DiffuseBack_U_Directon ("DiffuseBack_U_Directon", Float ) = 1
        _DiffuseBack_V_Direction ("DiffuseBack_V_Direction", Float ) = 1
        _DiffuseBack_Speed ("DiffuseBack_Speed", Range(0, 1)) = 0.424354
        _Normal ("Normal", 2D) = "bump" {}
        _ReampTexture ("ReampTexture", 2D) = "white" {}
        _Remap ("Remap", Range(0, 1)) = 0
        _Color_Fade ("Color_Fade", Color) = (0,1,0.2965517,1)
        _Dist ("Dist", Float ) = 50
        _PosterizeDist ("PosterizeDist", Float ) = 3
        _Glossiness_Color ("Glossiness_Color", Color) = (1,0,0,1)
        _Glossiness ("Glossiness", Range(1, 12)) = 1
        _PosterizeLight ("PosterizeLight", Float ) = 10
        _distort ("distort", Range(0, 1)) = 0
        _RemapDistort ("RemapDistort", Range(0, 1)) = 0.5095199
    }
    SubShader {
        Tags {
            "RenderType"="Opaque"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma only_renderers d3d9 d3d11 glcore gles gles3 
            #pragma target 2.0
            uniform float4 _TimeEditor;
            uniform float4 _Color1;
            uniform float4 _Color2;
            uniform float _Dist;
            uniform float4 _Color_Fade;
            uniform float _PosterizeDist;
            uniform float _Glossiness;
            uniform float _PosterizeLight;
            uniform sampler2D _Normal; uniform float4 _Normal_ST;
            uniform float4 _Glossiness_Color;
            uniform float _Remap;
            uniform sampler2D _ReampTexture; uniform float4 _ReampTexture_ST;
            uniform sampler2D _Diffuse; uniform float4 _Diffuse_ST;
            uniform float4 _Color3;
            uniform float _DiffuseBack_Speed;
            uniform float _DiffuseBack_U_Directon;
            uniform float _DiffuseBack_V_Direction;
            uniform float _DiffuseFront_U_Direction;
            uniform float _DiffuseFront_V_Direction;
            uniform float _DiffuseFront_Speed;
            uniform float _distort;
            uniform float _RemapDistort;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                float3 tangentDir : TEXCOORD3;
                float3 bitangentDir : TEXCOORD4;
                LIGHTING_COORDS(5,6)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( unity_ObjectToWorld, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float4 node_3824 = _Time + _TimeEditor;
                float4 node_8723 = tex2D(_ReampTexture,TRANSFORM_TEX(i.uv0, _ReampTexture));
                float3 node_3714 = lerp(((node_8723.rgb+_RemapDistort)*2.0+-1.0),float3(i.uv0,0.0),_distort);
                float3 node_1640 = (float3((node_3824.g*float2(_DiffuseBack_U_Directon,_DiffuseBack_V_Direction)*_DiffuseBack_Speed),0.0)+node_3714);
                float3 node_4893 = UnpackNormal(tex2D(_Normal,TRANSFORM_TEX(node_1640, _Normal)));
                float3 node_7868 = (float3((float2(_DiffuseFront_U_Direction,_DiffuseFront_V_Direction)*_DiffuseFront_Speed*node_3824.g),0.0)+node_3714);
                float3 node_3571 = UnpackNormal(tex2D(_Normal,TRANSFORM_TEX(node_7868, _Normal)));
                float3 node_9535_nrm_base = node_4893.rgb + float3(0,0,1);
                float3 node_9535_nrm_detail = node_3571.rgb * float3(-1,-1,1);
                float3 node_9535_nrm_combined = node_9535_nrm_base*dot(node_9535_nrm_base, node_9535_nrm_detail)/node_9535_nrm_base.z - node_9535_nrm_detail;
                float3 node_9535 = node_9535_nrm_combined;
                float4 node_3295 = tex2D(_ReampTexture,TRANSFORM_TEX(node_7868, _ReampTexture));
                float4 node_9142 = tex2D(_ReampTexture,TRANSFORM_TEX(node_1640, _ReampTexture));
                float3 node_8361_nrm_base = node_9535 + float3(0,0,1);
                float3 node_8361_nrm_detail = (((node_3295.rgb*node_9142.rgb)+_Remap)*3.0+-2.0) * float3(-1,-1,1);
                float3 node_8361_nrm_combined = node_8361_nrm_base*dot(node_8361_nrm_base, node_8361_nrm_detail)/node_8361_nrm_base.z - node_8361_nrm_detail;
                float3 node_8361 = node_8361_nrm_combined;
                float3 normalLocal = node_8361;
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float3 viewReflectDirection = reflect( -viewDirection, normalDirection );
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
////// Lighting:
////// Emissive:
                float4 node_239 = tex2D(_Diffuse,TRANSFORM_TEX(node_1640, _Diffuse));
                float4 node_2561 = tex2D(_Diffuse,TRANSFORM_TEX(node_7868, _Diffuse));
                float3 emissive = lerp(lerp(_Color3.rgb,lerp(_Color1.rgb,_Color2.rgb,node_239.rgb),(1.0 - node_2561.rgb)),_Color_Fade.rgb,floor((distance(i.posWorld.rgb,_WorldSpaceCameraPos)/_Dist) * _PosterizeDist) / (_PosterizeDist - 1));
                float3 finalColor = emissive + floor((max(0,dot(normalDirection,lightDirection))*(pow(max(0,dot(lightDirection,viewReflectDirection)),exp(_Glossiness))*_Glossiness_Color.rgb)) * _PosterizeLight) / (_PosterizeLight - 1);
                return fixed4(finalColor,1);
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
