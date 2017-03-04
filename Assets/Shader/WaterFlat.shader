// Upgrade NOTE: replaced '_Object2World' with 'unity_ObjectToWorld'

// Shader created with Shader Forge v1.32 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.32;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:0,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:True,fnsp:False,fnfb:False;n:type:ShaderForge.SFN_Final,id:3138,x:34040,y:32553,varname:node_3138,prsc:2|emission-7186-OUT,custl-7186-OUT,olwid-8133-OUT,olcol-2022-RGB,voffset-6615-OUT;n:type:ShaderForge.SFN_Color,id:7241,x:31716,y:32386,ptovrint:False,ptlb:Color1,ptin:_Color1,varname:node_7241,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.07843138,c2:0.3921569,c3:0.7843137,c4:1;n:type:ShaderForge.SFN_ComponentMask,id:7309,x:31698,y:33661,varname:node_7309,prsc:2,cc1:0,cc2:-1,cc3:-1,cc4:-1|IN-6244-XYZ;n:type:ShaderForge.SFN_Sin,id:2372,x:32650,y:33417,varname:node_2372,prsc:2|IN-8391-OUT;n:type:ShaderForge.SFN_Multiply,id:8391,x:32291,y:33417,varname:node_8391,prsc:2|A-5711-OUT,B-3703-OUT;n:type:ShaderForge.SFN_Slider,id:3703,x:32076,y:33322,ptovrint:False,ptlb:Wave_Quantity_U,ptin:_Wave_Quantity_U,varname:node_571,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:5.128204,max:100;n:type:ShaderForge.SFN_ComponentMask,id:1668,x:31698,y:33822,varname:node_1668,prsc:2,cc1:2,cc2:-1,cc3:-1,cc4:-1|IN-6244-XYZ;n:type:ShaderForge.SFN_Multiply,id:7273,x:32266,y:33700,varname:node_7273,prsc:2|A-788-OUT,B-8183-OUT;n:type:ShaderForge.SFN_Slider,id:8183,x:32087,y:33866,ptovrint:False,ptlb:Wave_Quantity_V,ptin:_Wave_Quantity_V,varname:_Wave_Intensity_U_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0.1,cur:14.29186,max:100;n:type:ShaderForge.SFN_Sin,id:3326,x:32504,y:33700,varname:node_3326,prsc:2|IN-7273-OUT;n:type:ShaderForge.SFN_Add,id:5711,x:32076,y:33414,varname:node_5711,prsc:2|A-8945-OUT,B-7309-OUT;n:type:ShaderForge.SFN_Add,id:788,x:32073,y:33717,varname:node_788,prsc:2|A-7820-OUT,B-1668-OUT;n:type:ShaderForge.SFN_Multiply,id:7442,x:33149,y:33652,varname:node_7442,prsc:2|A-7803-OUT,B-3765-OUT,C-2642-OUT;n:type:ShaderForge.SFN_Slider,id:3765,x:33029,y:33845,ptovrint:False,ptlb:Wave_Intensity_V,ptin:_Wave_Intensity_V,varname:node_8347,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.1,max:5;n:type:ShaderForge.SFN_Slider,id:4143,x:32991,y:33268,ptovrint:False,ptlb:Wave_Intensity_U,ptin:_Wave_Intensity_U,varname:_Wave_Intensity_V_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.1,max:5;n:type:ShaderForge.SFN_Multiply,id:9921,x:33148,y:33383,varname:node_9921,prsc:2|A-988-OUT,B-4143-OUT,C-2642-OUT;n:type:ShaderForge.SFN_Add,id:6615,x:33434,y:33509,varname:node_6615,prsc:2|A-9921-OUT,B-7442-OUT;n:type:ShaderForge.SFN_Clamp01,id:7803,x:32724,y:33700,varname:node_7803,prsc:2|IN-3326-OUT;n:type:ShaderForge.SFN_Clamp01,id:988,x:32858,y:33417,varname:node_988,prsc:2|IN-2372-OUT;n:type:ShaderForge.SFN_Time,id:8487,x:31431,y:33243,varname:node_8487,prsc:2;n:type:ShaderForge.SFN_Slider,id:7823,x:31311,y:33416,ptovrint:False,ptlb:Wave_Speed_U,ptin:_Wave_Speed_U,varname:node_7823,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1.253354,max:10;n:type:ShaderForge.SFN_Slider,id:3426,x:31311,y:33504,ptovrint:False,ptlb:Wave_Speed_V,ptin:_Wave_Speed_V,varname:_node_7823_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.3904247,max:10;n:type:ShaderForge.SFN_Multiply,id:8945,x:31750,y:33352,varname:node_8945,prsc:2|A-8487-T,B-7823-OUT;n:type:ShaderForge.SFN_Multiply,id:7820,x:31750,y:33474,varname:node_7820,prsc:2|A-8487-T,B-3426-OUT;n:type:ShaderForge.SFN_Tex2d,id:4584,x:31543,y:32813,ptovrint:False,ptlb:alpha,ptin:_alpha,varname:node_4584,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:271e3f0231ab1744fb9106a87a61e131,ntxv:0,isnm:False|UVIN-7604-OUT,MIP-2978-OUT;n:type:ShaderForge.SFN_Lerp,id:6174,x:32048,y:32732,varname:node_6174,prsc:2|A-7241-RGB,B-2891-RGB,T-4584-RGB;n:type:ShaderForge.SFN_Color,id:2891,x:31692,y:32621,ptovrint:False,ptlb:Color2,ptin:_Color2,varname:_Color_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.05758001,c2:0.264015,c3:0.5220588,c4:1;n:type:ShaderForge.SFN_FragmentPosition,id:7053,x:32217,y:32440,varname:node_7053,prsc:2;n:type:ShaderForge.SFN_Distance,id:5508,x:32444,y:32362,varname:node_5508,prsc:2|A-7053-XYZ,B-4608-XYZ;n:type:ShaderForge.SFN_Divide,id:7754,x:32768,y:32388,varname:node_7754,prsc:2|A-5508-OUT,B-7184-OUT;n:type:ShaderForge.SFN_ValueProperty,id:7184,x:32768,y:32192,ptovrint:False,ptlb:Dist,ptin:_Dist,varname:node_7184,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:50;n:type:ShaderForge.SFN_Lerp,id:7186,x:33448,y:32485,varname:node_7186,prsc:2|A-1776-OUT,B-2807-RGB,T-2978-OUT;n:type:ShaderForge.SFN_Color,id:2807,x:32681,y:32742,ptovrint:False,ptlb:Color_Fade,ptin:_Color_Fade,varname:node_2807,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0,c2:1,c3:0.2965517,c4:1;n:type:ShaderForge.SFN_Posterize,id:2978,x:32974,y:32377,varname:node_2978,prsc:2|IN-7754-OUT,STPS-9161-OUT;n:type:ShaderForge.SFN_ValueProperty,id:9161,x:32768,y:32268,ptovrint:False,ptlb:Posterize,ptin:_Posterize,varname:node_9161,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:3;n:type:ShaderForge.SFN_ViewPosition,id:4608,x:32217,y:32303,varname:node_4608,prsc:2;n:type:ShaderForge.SFN_FragmentPosition,id:6244,x:30985,y:33631,varname:node_6244,prsc:2;n:type:ShaderForge.SFN_Vector3,id:15,x:30001,y:32857,varname:node_15,prsc:2,v1:1,v2:0,v3:0;n:type:ShaderForge.SFN_NormalVector,id:2642,x:32917,y:33563,prsc:2,pt:False;n:type:ShaderForge.SFN_Normalize,id:3542,x:32444,y:32558,varname:node_3542,prsc:2|IN-7053-XYZ;n:type:ShaderForge.SFN_ComponentMask,id:4191,x:32724,y:32557,varname:node_4191,prsc:2,cc1:1,cc2:-1,cc3:-1,cc4:-1|IN-3542-OUT;n:type:ShaderForge.SFN_TexCoord,id:369,x:30312,y:32902,varname:node_369,prsc:2,uv:0;n:type:ShaderForge.SFN_Time,id:3824,x:30146,y:32527,varname:node_3824,prsc:2;n:type:ShaderForge.SFN_Sin,id:2836,x:30683,y:32687,varname:node_2836,prsc:2|IN-6249-OUT;n:type:ShaderForge.SFN_Add,id:7604,x:31204,y:32750,varname:node_7604,prsc:2|A-2120-OUT,B-6606-OUT,C-4127-UVOUT;n:type:ShaderForge.SFN_Multiply,id:6249,x:30403,y:32711,varname:node_6249,prsc:2|A-3824-T,B-7629-OUT,C-15-OUT;n:type:ShaderForge.SFN_Slider,id:7629,x:29970,y:32741,ptovrint:False,ptlb:Vitesse_U,ptin:_Vitesse_U,varname:node_7629,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.3640184,max:1;n:type:ShaderForge.SFN_RemapRange,id:2120,x:30895,y:32687,varname:node_2120,prsc:2,frmn:-1,frmx:1,tomn:0.5,tomx:0|IN-2836-OUT;n:type:ShaderForge.SFN_Vector3,id:304,x:29986,y:32488,varname:node_304,prsc:2,v1:0,v2:1,v3:0;n:type:ShaderForge.SFN_Multiply,id:9517,x:30418,y:32464,varname:node_9517,prsc:2|A-3824-T,B-8998-OUT,C-304-OUT,D-2989-OUT;n:type:ShaderForge.SFN_Slider,id:8998,x:29955,y:32372,ptovrint:False,ptlb:Vitesse_V,ptin:_Vitesse_V,varname:_Vitesse_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:1;n:type:ShaderForge.SFN_Sin,id:6606,x:30699,y:32507,varname:node_6606,prsc:2|IN-9517-OUT;n:type:ShaderForge.SFN_Vector1,id:2989,x:30323,y:32631,varname:node_2989,prsc:2,v1:0.1;n:type:ShaderForge.SFN_Rotator,id:4127,x:30949,y:32896,varname:node_4127,prsc:2|UVIN-369-UVOUT,SPD-1603-OUT;n:type:ShaderForge.SFN_Multiply,id:1603,x:30534,y:32968,varname:node_1603,prsc:2|A-3824-T,B-7456-OUT;n:type:ShaderForge.SFN_Slider,id:7456,x:30175,y:33103,ptovrint:False,ptlb:Vitesse_Rotation,ptin:_Vitesse_Rotation,varname:node_7456,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.0001,max:0.0001;n:type:ShaderForge.SFN_Tex2d,id:5157,x:31543,y:33005,ptovrint:False,ptlb:Alpha_2,ptin:_Alpha_2,varname:node_5157,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:4d3dc4828da1048409189d237efb96a9,ntxv:0,isnm:False|UVIN-369-UVOUT,MIP-2978-OUT;n:type:ShaderForge.SFN_Slider,id:8133,x:33028,y:32888,ptovrint:False,ptlb:Outline,ptin:_Outline,varname:node_8133,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.08682329,max:1;n:type:ShaderForge.SFN_Color,id:2022,x:33094,y:33023,ptovrint:False,ptlb:Outline_Color,ptin:_Outline_Color,varname:node_2022,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0,c2:0.6689653,c3:1,c4:1;n:type:ShaderForge.SFN_Clamp01,id:1776,x:32656,y:32941,varname:node_1776,prsc:2|IN-215-OUT;n:type:ShaderForge.SFN_Add,id:215,x:32356,y:32908,varname:node_215,prsc:2|A-6174-OUT,B-5157-RGB;proporder:7241-2891-3703-4143-7823-8183-3765-3426-4584-7629-8998-7456-2807-7184-9161-5157-8133-2022;pass:END;sub:END;*/

Shader "Shader Forge/water" {
    Properties {
        _Color1 ("Color1", Color) = (0.07843138,0.3921569,0.7843137,1)
        _Color2 ("Color2", Color) = (0.05758001,0.264015,0.5220588,1)
        _Wave_Quantity_U ("Wave_Quantity_U", Range(0, 100)) = 5.128204
        _Wave_Intensity_U ("Wave_Intensity_U", Range(0, 5)) = 0.1
        _Wave_Speed_U ("Wave_Speed_U", Range(0, 10)) = 1.253354
        _Wave_Quantity_V ("Wave_Quantity_V", Range(0.1, 100)) = 14.29186
        _Wave_Intensity_V ("Wave_Intensity_V", Range(0, 5)) = 0.1
        _Wave_Speed_V ("Wave_Speed_V", Range(0, 10)) = 0.3904247
        _alpha ("alpha", 2D) = "white" {}
        _Vitesse_U ("Vitesse_U", Range(0, 1)) = 0.3640184
        _Vitesse_V ("Vitesse_V", Range(0, 1)) = 1
        _Vitesse_Rotation ("Vitesse_Rotation", Range(0, 0.0001)) = 0.0001
        _Color_Fade ("Color_Fade", Color) = (0,1,0.2965517,1)
        _Dist ("Dist", Float ) = 50
        _Posterize ("Posterize", Float ) = 3
        _Alpha_2 ("Alpha_2", 2D) = "white" {}
        _Outline ("Outline", Range(0, 1)) = 0.08682329
        _Outline_Color ("Outline_Color", Color) = (0,0.6689653,1,1)
    }
    SubShader {
        Tags {
            "RenderType"="Opaque"
        }
        Pass {
            Name "Outline"
            Tags {
            }
            Cull Front
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma only_renderers d3d9 d3d11 glcore gles gles3 
            #pragma target 2.0
            uniform float4 _TimeEditor;
            uniform float _Wave_Quantity_U;
            uniform float _Wave_Quantity_V;
            uniform float _Wave_Intensity_V;
            uniform float _Wave_Intensity_U;
            uniform float _Wave_Speed_U;
            uniform float _Wave_Speed_V;
            uniform float _Outline;
            uniform float4 _Outline_Color;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float4 posWorld : TEXCOORD0;
                float3 normalDir : TEXCOORD1;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                float4 node_8487 = _Time + _TimeEditor;
                v.vertex.xyz += ((saturate(sin((((node_8487.g*_Wave_Speed_U)+mul(unity_ObjectToWorld, v.vertex).rgb.r)*_Wave_Quantity_U)))*_Wave_Intensity_U*v.normal)+(saturate(sin((((node_8487.g*_Wave_Speed_V)+mul(unity_ObjectToWorld, v.vertex).rgb.b)*_Wave_Quantity_V)))*_Wave_Intensity_V*v.normal));
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = mul(UNITY_MATRIX_MVP, float4(v.vertex.xyz + normalize(v.vertex)*_Outline,1) );
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3 normalDirection = i.normalDir;
                return fixed4(_Outline_Color.rgb,0);
            }
            ENDCG
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
            uniform float _Wave_Quantity_U;
            uniform float _Wave_Quantity_V;
            uniform float _Wave_Intensity_V;
            uniform float _Wave_Intensity_U;
            uniform float _Wave_Speed_U;
            uniform float _Wave_Speed_V;
            uniform sampler2D _alpha; uniform float4 _alpha_ST;
            uniform float4 _Color2;
            uniform float _Dist;
            uniform float4 _Color_Fade;
            uniform float _Posterize;
            uniform float _Vitesse_U;
            uniform float _Vitesse_V;
            uniform float _Vitesse_Rotation;
            uniform sampler2D _Alpha_2; uniform float4 _Alpha_2_ST;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                float4 node_8487 = _Time + _TimeEditor;
                v.vertex.xyz += ((saturate(sin((((node_8487.g*_Wave_Speed_U)+mul(unity_ObjectToWorld, v.vertex).rgb.r)*_Wave_Quantity_U)))*_Wave_Intensity_U*v.normal)+(saturate(sin((((node_8487.g*_Wave_Speed_V)+mul(unity_ObjectToWorld, v.vertex).rgb.b)*_Wave_Quantity_V)))*_Wave_Intensity_V*v.normal));
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3 normalDirection = i.normalDir;
////// Lighting:
////// Emissive:
                float4 node_3824 = _Time + _TimeEditor;
                float4 node_5556 = _Time + _TimeEditor;
                float node_4127_ang = node_5556.g;
                float node_4127_spd = (node_3824.g*_Vitesse_Rotation);
                float node_4127_cos = cos(node_4127_spd*node_4127_ang);
                float node_4127_sin = sin(node_4127_spd*node_4127_ang);
                float2 node_4127_piv = float2(0.5,0.5);
                float2 node_4127 = (mul(i.uv0-node_4127_piv,float2x2( node_4127_cos, -node_4127_sin, node_4127_sin, node_4127_cos))+node_4127_piv);
                float3 node_7604 = ((sin((node_3824.g*_Vitesse_U*float3(1,0,0)))*-0.25+0.25)+sin((node_3824.g*_Vitesse_V*float3(0,1,0)*0.1))+float3(node_4127,0.0));
                float node_2978 = floor((distance(i.posWorld.rgb,_WorldSpaceCameraPos)/_Dist) * _Posterize) / (_Posterize - 1);
                float4 _alpha_var = tex2Dlod(_alpha,float4(TRANSFORM_TEX(node_7604, _alpha),0.0,node_2978));
                float4 _Alpha_2_var = tex2Dlod(_Alpha_2,float4(TRANSFORM_TEX(i.uv0, _Alpha_2),0.0,node_2978));
                float3 node_7186 = lerp(saturate((lerp(_Color1.rgb,_Color2.rgb,_alpha_var.rgb)+_Alpha_2_var.rgb)),_Color_Fade.rgb,node_2978);
                float3 emissive = node_7186;
                float3 finalColor = emissive + node_7186;
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
            uniform float _Wave_Quantity_U;
            uniform float _Wave_Quantity_V;
            uniform float _Wave_Intensity_V;
            uniform float _Wave_Intensity_U;
            uniform float _Wave_Speed_U;
            uniform float _Wave_Speed_V;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
            };
            struct VertexOutput {
                V2F_SHADOW_CASTER;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                float4 node_8487 = _Time + _TimeEditor;
                v.vertex.xyz += ((saturate(sin((((node_8487.g*_Wave_Speed_U)+mul(unity_ObjectToWorld, v.vertex).rgb.r)*_Wave_Quantity_U)))*_Wave_Intensity_U*v.normal)+(saturate(sin((((node_8487.g*_Wave_Speed_V)+mul(unity_ObjectToWorld, v.vertex).rgb.b)*_Wave_Quantity_V)))*_Wave_Intensity_V*v.normal));
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
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
