// Shader created with Shader Forge v1.32 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.32;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:True,fnsp:False,fnfb:False;n:type:ShaderForge.SFN_Final,id:3138,x:32954,y:32705,varname:node_3138,prsc:2|emission-2024-OUT,voffset-7516-OUT;n:type:ShaderForge.SFN_Color,id:7241,x:31816,y:32069,ptovrint:False,ptlb:Color1,ptin:_Color1,varname:node_7241,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.07843138,c2:0.3921569,c3:0.7843137,c4:1;n:type:ShaderForge.SFN_TexCoord,id:9312,x:31181,y:32795,varname:node_9312,prsc:2,uv:0;n:type:ShaderForge.SFN_ComponentMask,id:4820,x:31390,y:32795,varname:node_4820,prsc:2,cc1:0,cc2:-1,cc3:-1,cc4:-1|IN-9312-UVOUT;n:type:ShaderForge.SFN_Add,id:4687,x:31614,y:32778,varname:node_4687,prsc:2|A-5130-OUT,B-4820-OUT;n:type:ShaderForge.SFN_Time,id:5696,x:30913,y:32460,varname:node_5696,prsc:2;n:type:ShaderForge.SFN_Multiply,id:7410,x:31156,y:32510,varname:node_7410,prsc:2|A-5696-T,B-3193-OUT;n:type:ShaderForge.SFN_Slider,id:3193,x:30756,y:32623,ptovrint:False,ptlb:Speed,ptin:_Speed,varname:node_3193,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.4015985,max:2;n:type:ShaderForge.SFN_Multiply,id:2381,x:31844,y:32760,varname:node_2381,prsc:2|A-2975-OUT,B-4687-OUT;n:type:ShaderForge.SFN_Slider,id:2975,x:31687,y:32666,ptovrint:False,ptlb:Quantity,ptin:_Quantity,varname:node_2975,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:28.84866,max:100;n:type:ShaderForge.SFN_Sin,id:8384,x:32045,y:32760,varname:node_8384,prsc:2|IN-2381-OUT;n:type:ShaderForge.SFN_Multiply,id:6695,x:32493,y:32760,varname:node_6695,prsc:2|A-9750-OUT,B-3903-OUT,C-3880-OUT;n:type:ShaderForge.SFN_Slider,id:3903,x:32034,y:32674,ptovrint:False,ptlb:Intensity,ptin:_Intensity,varname:node_3903,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.2712413,max:1;n:type:ShaderForge.SFN_Multiply,id:7516,x:32761,y:32929,varname:node_7516,prsc:2|A-6695-OUT,B-3432-OUT;n:type:ShaderForge.SFN_ComponentMask,id:9663,x:31390,y:32979,varname:node_9663,prsc:2,cc1:1,cc2:-1,cc3:-1,cc4:-1|IN-9312-UVOUT;n:type:ShaderForge.SFN_OneMinus,id:4638,x:31582,y:33146,varname:node_4638,prsc:2|IN-9663-OUT;n:type:ShaderForge.SFN_Multiply,id:2714,x:31754,y:32988,varname:node_2714,prsc:2|A-9663-OUT,B-4638-OUT;n:type:ShaderForge.SFN_RemapRange,id:3880,x:31940,y:32988,varname:node_3880,prsc:2,frmn:0,frmx:0.3,tomn:0,tomx:1|IN-2714-OUT;n:type:ShaderForge.SFN_Add,id:710,x:31921,y:33433,varname:node_710,prsc:2|A-9851-OUT,B-8322-OUT;n:type:ShaderForge.SFN_Normalize,id:3432,x:32092,y:33433,varname:node_3432,prsc:2|IN-710-OUT;n:type:ShaderForge.SFN_NormalVector,id:8322,x:31673,y:33587,prsc:2,pt:False;n:type:ShaderForge.SFN_ValueProperty,id:7981,x:31431,y:33378,ptovrint:False,ptlb:R,ptin:_R,varname:node_7981,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_ValueProperty,id:4234,x:31431,y:33455,ptovrint:False,ptlb:G,ptin:_G,varname:node_4234,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_ValueProperty,id:6316,x:31431,y:33536,ptovrint:False,ptlb:B,ptin:_B,varname:node_6316,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_Append,id:9851,x:31690,y:33416,varname:node_9851,prsc:2|A-7981-OUT,B-4234-OUT,C-6316-OUT;n:type:ShaderForge.SFN_OneMinus,id:5130,x:31389,y:32571,varname:node_5130,prsc:2|IN-7410-OUT;n:type:ShaderForge.SFN_Tex2d,id:9812,x:31816,y:32403,ptovrint:False,ptlb:Text,ptin:_Text,varname:node_9812,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Color,id:2290,x:31816,y:32239,ptovrint:False,ptlb:Color2,ptin:_Color2,varname:node_2290,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:1,c3:1,c4:1;n:type:ShaderForge.SFN_Lerp,id:2024,x:32093,y:32321,varname:node_2024,prsc:2|A-7241-RGB,B-2290-RGB,T-9812-RGB;n:type:ShaderForge.SFN_RemapRange,id:9750,x:32224,y:32760,varname:node_9750,prsc:2,frmn:-1,frmx:1,tomn:0,tomx:1|IN-8384-OUT;proporder:7241-3193-2975-3903-7981-4234-6316-9812-2290;pass:END;sub:END;*/

Shader "Shader Forge/waterIdle" {
    Properties {
        _Color1 ("Color1", Color) = (0.07843138,0.3921569,0.7843137,1)
        _Speed ("Speed", Range(0, 2)) = 0.4015985
        _Quantity ("Quantity", Range(0, 100)) = 28.84866
        _Intensity ("Intensity", Range(0, 1)) = 0.2712413
        _R ("R", Float ) = 0
        _G ("G", Float ) = 1
        _B ("B", Float ) = 0
        _Text ("Text", 2D) = "white" {}
        _Color2 ("Color2", Color) = (1,1,1,1)
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
            #pragma multi_compile_fwdbase_fullshadows
            #pragma only_renderers d3d9 d3d11 glcore gles gles3 
            #pragma target 2.0
            uniform float4 _TimeEditor;
            uniform float4 _Color1;
            uniform float _Speed;
            uniform float _Quantity;
            uniform float _Intensity;
            uniform float _R;
            uniform float _G;
            uniform float _B;
            uniform sampler2D _Text; uniform float4 _Text_ST;
            uniform float4 _Color2;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float3 normalDir : TEXCOORD1;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                float4 node_5696 = _Time + _TimeEditor;
                float node_9663 = o.uv0.g;
                v.vertex.xyz += (((sin((_Quantity*((1.0 - (node_5696.g*_Speed))+o.uv0.r)))*0.5+0.5)*_Intensity*((node_9663*(1.0 - node_9663))*3.333333+0.0))*normalize((float3(_R,_G,_B)+v.normal)));
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3 normalDirection = i.normalDir;
////// Lighting:
////// Emissive:
                float4 _Text_var = tex2D(_Text,TRANSFORM_TEX(i.uv0, _Text));
                float3 emissive = lerp(_Color1.rgb,_Color2.rgb,_Text_var.rgb);
                float3 finalColor = emissive;
                return fixed4(finalColor,1);
            }
            ENDCG
        }
        Pass {
            Name "ShadowCaster"
            Tags {
                "LightMode"="ShadowCaster"
            }
            Offset 1, 1
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_SHADOWCASTER
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma only_renderers d3d9 d3d11 glcore gles gles3 
            #pragma target 2.0
            uniform float4 _TimeEditor;
            uniform float _Speed;
            uniform float _Quantity;
            uniform float _Intensity;
            uniform float _R;
            uniform float _G;
            uniform float _B;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                V2F_SHADOW_CASTER;
                float2 uv0 : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                float4 node_5696 = _Time + _TimeEditor;
                float node_9663 = o.uv0.g;
                v.vertex.xyz += (((sin((_Quantity*((1.0 - (node_5696.g*_Speed))+o.uv0.r)))*0.5+0.5)*_Intensity*((node_9663*(1.0 - node_9663))*3.333333+0.0))*normalize((float3(_R,_G,_B)+v.normal)));
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                TRANSFER_SHADOW_CASTER(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3 normalDirection = i.normalDir;
                SHADOW_CASTER_FRAGMENT(i)
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
