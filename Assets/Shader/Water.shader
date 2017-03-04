// Upgrade NOTE: replaced '_Object2World' with 'unity_ObjectToWorld'

// Shader created with Shader Forge v1.32 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.32;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:0,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:True,fnsp:False,fnfb:False;n:type:ShaderForge.SFN_Final,id:3138,x:33785,y:32636,varname:node_3138,prsc:2|emission-7186-OUT,olwid-7772-OUT,olcol-765-RGB,voffset-6615-OUT;n:type:ShaderForge.SFN_Color,id:7241,x:31716,y:32386,ptovrint:False,ptlb:Color1,ptin:_Color1,varname:node_7241,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.07843138,c2:0.3921569,c3:0.7843137,c4:1;n:type:ShaderForge.SFN_ComponentMask,id:7309,x:30759,y:33633,varname:node_7309,prsc:2,cc1:0,cc2:-1,cc3:-1,cc4:-1|IN-6244-XYZ;n:type:ShaderForge.SFN_Sin,id:2372,x:31711,y:33389,varname:node_2372,prsc:2|IN-8391-OUT;n:type:ShaderForge.SFN_Multiply,id:8391,x:31352,y:33389,varname:node_8391,prsc:2|A-5711-OUT,B-3703-OUT;n:type:ShaderForge.SFN_Slider,id:3703,x:31137,y:33294,ptovrint:False,ptlb:Wave_Quantity_U,ptin:_Wave_Quantity_U,varname:node_571,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:5.128204,max:100;n:type:ShaderForge.SFN_ComponentMask,id:1668,x:30759,y:33794,varname:node_1668,prsc:2,cc1:2,cc2:-1,cc3:-1,cc4:-1|IN-6244-XYZ;n:type:ShaderForge.SFN_Multiply,id:7273,x:31327,y:33672,varname:node_7273,prsc:2|A-788-OUT,B-8183-OUT;n:type:ShaderForge.SFN_Slider,id:8183,x:31148,y:33838,ptovrint:False,ptlb:Wave_Quantity_V,ptin:_Wave_Quantity_V,varname:_Wave_Intensity_U_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0.1,cur:14.29186,max:100;n:type:ShaderForge.SFN_Sin,id:3326,x:31565,y:33672,varname:node_3326,prsc:2|IN-7273-OUT;n:type:ShaderForge.SFN_Add,id:5711,x:31137,y:33386,varname:node_5711,prsc:2|A-8945-OUT,B-7309-OUT;n:type:ShaderForge.SFN_Add,id:788,x:31134,y:33689,varname:node_788,prsc:2|A-7820-OUT,B-1668-OUT;n:type:ShaderForge.SFN_Multiply,id:7442,x:32210,y:33624,varname:node_7442,prsc:2|A-7803-OUT,B-3765-OUT,C-2642-OUT;n:type:ShaderForge.SFN_Slider,id:3765,x:32090,y:33817,ptovrint:False,ptlb:Wave_Intensity_V,ptin:_Wave_Intensity_V,varname:node_8347,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.1,max:5;n:type:ShaderForge.SFN_Slider,id:4143,x:32052,y:33240,ptovrint:False,ptlb:Wave_Intensity_U,ptin:_Wave_Intensity_U,varname:_Wave_Intensity_V_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.1,max:5;n:type:ShaderForge.SFN_Multiply,id:9921,x:32209,y:33355,varname:node_9921,prsc:2|A-988-OUT,B-4143-OUT,C-2642-OUT;n:type:ShaderForge.SFN_Add,id:6615,x:32495,y:33481,varname:node_6615,prsc:2|A-9921-OUT,B-7442-OUT;n:type:ShaderForge.SFN_Clamp01,id:7803,x:31785,y:33672,varname:node_7803,prsc:2|IN-3326-OUT;n:type:ShaderForge.SFN_Clamp01,id:988,x:31919,y:33389,varname:node_988,prsc:2|IN-2372-OUT;n:type:ShaderForge.SFN_Time,id:8487,x:30529,y:33224,varname:node_8487,prsc:2;n:type:ShaderForge.SFN_Slider,id:7823,x:30372,y:33388,ptovrint:False,ptlb:Wave_Speed_U,ptin:_Wave_Speed_U,varname:node_7823,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1.253354,max:10;n:type:ShaderForge.SFN_Slider,id:3426,x:30372,y:33476,ptovrint:False,ptlb:Wave_Speed_V,ptin:_Wave_Speed_V,varname:_node_7823_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.3904247,max:10;n:type:ShaderForge.SFN_Multiply,id:8945,x:30811,y:33324,varname:node_8945,prsc:2|A-8487-T,B-7823-OUT;n:type:ShaderForge.SFN_Multiply,id:7820,x:30811,y:33446,varname:node_7820,prsc:2|A-8487-T,B-3426-OUT;n:type:ShaderForge.SFN_Tex2d,id:4584,x:31434,y:32818,ptovrint:False,ptlb:alpha,ptin:_alpha,varname:node_4584,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:b6b3451afd6a34d47824960e5373f5fc,ntxv:0,isnm:False|UVIN-3397-UVOUT;n:type:ShaderForge.SFN_Lerp,id:6174,x:31994,y:32740,varname:node_6174,prsc:2|A-7241-RGB,B-2891-RGB,T-4584-RGB;n:type:ShaderForge.SFN_Color,id:2891,x:31692,y:32621,ptovrint:False,ptlb:Color2,ptin:_Color2,varname:_Color_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.05758001,c2:0.264015,c3:0.5220588,c4:1;n:type:ShaderForge.SFN_Rotator,id:3397,x:31179,y:32808,varname:node_3397,prsc:2|UVIN-2081-OUT,ANG-1472-OUT;n:type:ShaderForge.SFN_Pi,id:8274,x:30589,y:32758,varname:node_8274,prsc:2;n:type:ShaderForge.SFN_Vector1,id:9474,x:30589,y:32897,varname:node_9474,prsc:2,v1:180;n:type:ShaderForge.SFN_Divide,id:5206,x:30797,y:32808,varname:node_5206,prsc:2|A-8274-OUT,B-9474-OUT;n:type:ShaderForge.SFN_Multiply,id:1472,x:30991,y:32856,varname:node_1472,prsc:2|A-5206-OUT,B-3096-OUT;n:type:ShaderForge.SFN_FragmentPosition,id:7053,x:32217,y:32440,varname:node_7053,prsc:2;n:type:ShaderForge.SFN_Distance,id:5508,x:32444,y:32362,varname:node_5508,prsc:2|A-7053-XYZ,B-4608-XYZ;n:type:ShaderForge.SFN_Divide,id:7754,x:32768,y:32388,varname:node_7754,prsc:2|A-5508-OUT,B-7184-OUT;n:type:ShaderForge.SFN_ValueProperty,id:7184,x:32768,y:32192,ptovrint:False,ptlb:Dist,ptin:_Dist,varname:node_7184,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:50;n:type:ShaderForge.SFN_Lerp,id:7186,x:33375,y:32382,varname:node_7186,prsc:2|A-6174-OUT,B-2103-OUT,T-2978-OUT;n:type:ShaderForge.SFN_Color,id:2807,x:32724,y:32742,ptovrint:False,ptlb:ColorFade_Top,ptin:_ColorFade_Top,varname:node_2807,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0,c2:1,c3:0.2965517,c4:1;n:type:ShaderForge.SFN_Posterize,id:2978,x:32974,y:32377,varname:node_2978,prsc:2|IN-7754-OUT,STPS-9161-OUT;n:type:ShaderForge.SFN_ValueProperty,id:9161,x:32768,y:32268,ptovrint:False,ptlb:Posterize,ptin:_Posterize,varname:node_9161,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:3;n:type:ShaderForge.SFN_Multiply,id:9267,x:31163,y:32393,varname:node_9267,prsc:2|A-8487-T,B-8556-OUT,C-6306-OUT;n:type:ShaderForge.SFN_Add,id:2081,x:31366,y:32477,varname:node_2081,prsc:2|A-9267-OUT,B-62-UVOUT;n:type:ShaderForge.SFN_Slider,id:8556,x:30662,y:32412,ptovrint:False,ptlb:Texture speed,ptin:_Texturespeed,varname:node_8556,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.424354,max:1;n:type:ShaderForge.SFN_ViewPosition,id:4608,x:32217,y:32303,varname:node_4608,prsc:2;n:type:ShaderForge.SFN_TexCoord,id:62,x:30589,y:32597,varname:node_62,prsc:2,uv:0;n:type:ShaderForge.SFN_ValueProperty,id:3096,x:30633,y:33121,ptovrint:False,ptlb:rotate,ptin:_rotate,varname:node_3096,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_ValueProperty,id:1406,x:30181,y:32516,ptovrint:False,ptlb:U_Directon,ptin:_U_Directon,varname:node_1406,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_ValueProperty,id:8995,x:30192,y:32636,ptovrint:False,ptlb:V_Direction,ptin:_V_Direction,varname:node_8995,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_Append,id:6306,x:30429,y:32503,varname:node_6306,prsc:2|A-1406-OUT,B-8995-OUT;n:type:ShaderForge.SFN_FragmentPosition,id:6244,x:30046,y:33603,varname:node_6244,prsc:2;n:type:ShaderForge.SFN_NormalVector,id:2642,x:31978,y:33535,prsc:2,pt:False;n:type:ShaderForge.SFN_Normalize,id:3542,x:32444,y:32558,varname:node_3542,prsc:2|IN-7053-XYZ;n:type:ShaderForge.SFN_ComponentMask,id:4191,x:32724,y:32557,varname:node_4191,prsc:2,cc1:1,cc2:-1,cc3:-1,cc4:-1|IN-3542-OUT;n:type:ShaderForge.SFN_Color,id:9377,x:32724,y:32922,ptovrint:False,ptlb:ColorFade_Bot,ptin:_ColorFade_Bot,varname:node_9377,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0,c2:0.1724138,c3:1,c4:1;n:type:ShaderForge.SFN_Lerp,id:2103,x:33031,y:32518,varname:node_2103,prsc:2|A-9377-RGB,B-2807-RGB,T-4191-OUT;n:type:ShaderForge.SFN_Slider,id:7772,x:32979,y:32901,ptovrint:False,ptlb:Outline,ptin:_Outline,varname:node_7772,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.05148759,max:10;n:type:ShaderForge.SFN_Color,id:765,x:32979,y:33067,ptovrint:False,ptlb:Outline_Color,ptin:_Outline_Color,varname:node_765,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:1,c3:1,c4:1;proporder:7241-2891-3703-4143-7823-8183-3765-3426-4584-8556-3096-1406-8995-2807-9377-7184-9161-7772-765;pass:END;sub:END;*/

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
        _Texturespeed ("Texture speed", Range(0, 1)) = 0.424354
        _rotate ("rotate", Float ) = 0
        _U_Directon ("U_Directon", Float ) = 0
        _V_Direction ("V_Direction", Float ) = 0
        _ColorFade_Top ("ColorFade_Top", Color) = (0,1,0.2965517,1)
        _ColorFade_Bot ("ColorFade_Bot", Color) = (0,0.1724138,1,1)
        _Dist ("Dist", Float ) = 50
        _Posterize ("Posterize", Float ) = 3
        _Outline ("Outline", Range(0, 10)) = 0.05148759
        _Outline_Color ("Outline_Color", Color) = (1,1,1,1)
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
            uniform float4 _ColorFade_Top;
            uniform float _Posterize;
            uniform float _Texturespeed;
            uniform float _rotate;
            uniform float _U_Directon;
            uniform float _V_Direction;
            uniform float4 _ColorFade_Bot;
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
                float node_3397_ang = ((3.141592654/180.0)*_rotate);
                float node_3397_spd = 1.0;
                float node_3397_cos = cos(node_3397_spd*node_3397_ang);
                float node_3397_sin = sin(node_3397_spd*node_3397_ang);
                float2 node_3397_piv = float2(0.5,0.5);
                float4 node_8487 = _Time + _TimeEditor;
                float2 node_3397 = (mul(((node_8487.g*_Texturespeed*float2(_U_Directon,_V_Direction))+i.uv0)-node_3397_piv,float2x2( node_3397_cos, -node_3397_sin, node_3397_sin, node_3397_cos))+node_3397_piv);
                float4 _alpha_var = tex2D(_alpha,TRANSFORM_TEX(node_3397, _alpha));
                float3 emissive = lerp(lerp(_Color1.rgb,_Color2.rgb,_alpha_var.rgb),lerp(_ColorFade_Bot.rgb,_ColorFade_Top.rgb,normalize(i.posWorld.rgb).g),floor((distance(i.posWorld.rgb,_WorldSpaceCameraPos)/_Dist) * _Posterize) / (_Posterize - 1));
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
