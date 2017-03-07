// Upgrade NOTE: replaced '_Object2World' with 'unity_ObjectToWorld'

// Shader created with Shader Forge v1.32 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.32;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:2,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:True,fnsp:False,fnfb:False;n:type:ShaderForge.SFN_Final,id:3138,x:33250,y:33248,varname:node_3138,prsc:2|emission-128-OUT,voffset-2310-OUT;n:type:ShaderForge.SFN_Color,id:2570,x:31965,y:32664,ptovrint:False,ptlb:Color,ptin:_Color,varname:node_2570,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:0,c3:0,c4:1;n:type:ShaderForge.SFN_ComponentMask,id:6305,x:30960,y:33571,varname:node_6305,prsc:2,cc1:0,cc2:-1,cc3:-1,cc4:-1|IN-1079-UVOUT;n:type:ShaderForge.SFN_Sin,id:7820,x:31999,y:33433,varname:node_7820,prsc:2|IN-8733-OUT;n:type:ShaderForge.SFN_Multiply,id:8733,x:31820,y:33433,varname:node_8733,prsc:2|A-3241-OUT,B-2468-OUT;n:type:ShaderForge.SFN_Slider,id:2468,x:31601,y:33343,ptovrint:False,ptlb:Wave_Quantity_U,ptin:_Wave_Quantity_U,varname:node_571,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:12.4278,max:100;n:type:ShaderForge.SFN_Add,id:3241,x:31628,y:33433,varname:node_3241,prsc:2|A-8777-OUT,B-3244-OUT;n:type:ShaderForge.SFN_Slider,id:1253,x:32014,y:33326,ptovrint:False,ptlb:Wave_Intensity_U,ptin:_Wave_Intensity_U,varname:_Wave_Intensity_V_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.3904529,max:5;n:type:ShaderForge.SFN_Slider,id:7453,x:30575,y:33120,ptovrint:False,ptlb:Wave_Speed_U,ptin:_Wave_Speed_U,varname:node_7823,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:10;n:type:ShaderForge.SFN_Multiply,id:8777,x:31009,y:33107,varname:node_8777,prsc:2|A-7242-T,B-7453-OUT;n:type:ShaderForge.SFN_Time,id:7242,x:30766,y:32953,varname:node_7242,prsc:2;n:type:ShaderForge.SFN_NormalVector,id:2488,x:32171,y:33558,prsc:2,pt:False;n:type:ShaderForge.SFN_TexCoord,id:1079,x:30751,y:33571,varname:node_1079,prsc:2,uv:0;n:type:ShaderForge.SFN_OneMinus,id:3244,x:31437,y:33448,varname:node_3244,prsc:2|IN-6305-OUT;n:type:ShaderForge.SFN_Multiply,id:876,x:31628,y:33571,varname:node_876,prsc:2|A-6305-OUT,B-6305-OUT;n:type:ShaderForge.SFN_FragmentPosition,id:989,x:31424,y:32979,varname:node_989,prsc:2;n:type:ShaderForge.SFN_Distance,id:3914,x:31623,y:33024,varname:node_3914,prsc:2|A-989-XYZ,B-5614-XYZ;n:type:ShaderForge.SFN_Divide,id:1222,x:31785,y:33024,varname:node_1222,prsc:2|A-3914-OUT,B-9001-OUT;n:type:ShaderForge.SFN_ValueProperty,id:9001,x:31623,y:33166,ptovrint:False,ptlb:Dist,ptin:_Dist,varname:node_7184,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:10;n:type:ShaderForge.SFN_Posterize,id:2122,x:31971,y:33024,varname:node_2122,prsc:2|IN-1222-OUT,STPS-9502-OUT;n:type:ShaderForge.SFN_ValueProperty,id:9502,x:31785,y:33155,ptovrint:False,ptlb:Posterize,ptin:_Posterize,varname:node_9161,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:3;n:type:ShaderForge.SFN_ViewPosition,id:5614,x:31424,y:33108,varname:node_5614,prsc:2;n:type:ShaderForge.SFN_Color,id:4362,x:31971,y:32847,ptovrint:False,ptlb:Fade,ptin:_Fade,varname:node_4362,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.5,c2:0.5,c3:0.5,c4:1;n:type:ShaderForge.SFN_Lerp,id:128,x:32292,y:32985,varname:node_128,prsc:2|A-2570-RGB,B-4362-RGB,T-2122-OUT;n:type:ShaderForge.SFN_OneMinus,id:9419,x:31437,y:33701,varname:node_9419,prsc:2|IN-6305-OUT;n:type:ShaderForge.SFN_Multiply,id:3934,x:31815,y:33701,varname:node_3934,prsc:2|A-876-OUT,B-4346-OUT;n:type:ShaderForge.SFN_Multiply,id:4346,x:31628,y:33701,varname:node_4346,prsc:2|A-9419-OUT,B-9419-OUT;n:type:ShaderForge.SFN_Clamp01,id:5475,x:32186,y:33704,varname:node_5475,prsc:2|IN-2584-OUT;n:type:ShaderForge.SFN_Clamp01,id:8316,x:32171,y:33434,varname:node_8316,prsc:2|IN-7820-OUT;n:type:ShaderForge.SFN_Add,id:2584,x:32006,y:33704,varname:node_2584,prsc:2|A-3934-OUT,B-3934-OUT;n:type:ShaderForge.SFN_FragmentPosition,id:3815,x:31255,y:33819,varname:node_3815,prsc:2;n:type:ShaderForge.SFN_ComponentMask,id:7097,x:31437,y:33858,varname:node_7097,prsc:2,cc1:0,cc2:-1,cc3:-1,cc4:-1|IN-3815-Y;n:type:ShaderForge.SFN_Add,id:8478,x:31628,y:33858,varname:node_8478,prsc:2|A-7097-OUT,B-9665-OUT;n:type:ShaderForge.SFN_Multiply,id:9665,x:31014,y:33267,varname:node_9665,prsc:2|A-7242-T,B-331-OUT;n:type:ShaderForge.SFN_Slider,id:331,x:30522,y:33285,ptovrint:False,ptlb:Y_Global,ptin:_Y_Global,varname:node_331,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:10;n:type:ShaderForge.SFN_Multiply,id:4930,x:31815,y:33846,varname:node_4930,prsc:2|A-8478-OUT,B-6470-OUT;n:type:ShaderForge.SFN_Slider,id:6470,x:31492,y:34047,ptovrint:False,ptlb:Wave_Quantity_YGlobal,ptin:_Wave_Quantity_YGlobal,varname:node_6470,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:7.782138,max:100;n:type:ShaderForge.SFN_Sin,id:5009,x:32006,y:33846,varname:node_5009,prsc:2|IN-4930-OUT;n:type:ShaderForge.SFN_Clamp01,id:2035,x:32186,y:33846,varname:node_2035,prsc:2|IN-5009-OUT;n:type:ShaderForge.SFN_Multiply,id:2501,x:32373,y:33373,varname:node_2501,prsc:2|A-1253-OUT,B-8316-OUT,C-2488-OUT;n:type:ShaderForge.SFN_Multiply,id:1240,x:32601,y:33847,varname:node_1240,prsc:2|A-2035-OUT,B-7325-OUT,C-2488-OUT;n:type:ShaderForge.SFN_Slider,id:7325,x:32029,y:34023,ptovrint:False,ptlb:Wave_Intensity_YGlobal,ptin:_Wave_Intensity_YGlobal,varname:node_7325,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.4306996,max:5;n:type:ShaderForge.SFN_Add,id:1679,x:32824,y:33497,varname:node_1679,prsc:2|A-2501-OUT,B-1240-OUT;n:type:ShaderForge.SFN_Multiply,id:2310,x:32986,y:33588,varname:node_2310,prsc:2|A-1679-OUT,B-5475-OUT;proporder:2570-2468-1253-7453-9001-9502-4362-331-6470-7325;pass:END;sub:END;*/

Shader "Shader Forge/Windanimation" {
    Properties {
        _Color ("Color", Color) = (1,0,0,1)
        _Wave_Quantity_U ("Wave_Quantity_U", Range(0, 100)) = 12.4278
        _Wave_Intensity_U ("Wave_Intensity_U", Range(0, 5)) = 0.3904529
        _Wave_Speed_U ("Wave_Speed_U", Range(0, 10)) = 1
        _Dist ("Dist", Float ) = 10
        _Posterize ("Posterize", Float ) = 3
        _Fade ("Fade", Color) = (0.5,0.5,0.5,1)
        _Y_Global ("Y_Global", Range(0, 10)) = 0
        _Wave_Quantity_YGlobal ("Wave_Quantity_YGlobal", Range(0, 100)) = 7.782138
        _Wave_Intensity_YGlobal ("Wave_Intensity_YGlobal", Range(0, 5)) = 0.4306996
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
            Cull Off
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma only_renderers d3d9 d3d11 glcore gles gles3 
            #pragma target 2.0
            uniform float4 _TimeEditor;
            uniform float4 _Color;
            uniform float _Wave_Quantity_U;
            uniform float _Wave_Intensity_U;
            uniform float _Wave_Speed_U;
            uniform float _Dist;
            uniform float _Posterize;
            uniform float4 _Fade;
            uniform float _Y_Global;
            uniform float _Wave_Quantity_YGlobal;
            uniform float _Wave_Intensity_YGlobal;
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
                float4 node_7242 = _Time + _TimeEditor;
                float node_6305 = o.uv0.r;
                float node_9419 = (1.0 - node_6305);
                float node_3934 = ((node_6305*node_6305)*(node_9419*node_9419));
                v.vertex.xyz += (((_Wave_Intensity_U*saturate(sin((((node_7242.g*_Wave_Speed_U)+(1.0 - node_6305))*_Wave_Quantity_U)))*v.normal)+(saturate(sin(((mul(unity_ObjectToWorld, v.vertex).g.r+(node_7242.g*_Y_Global))*_Wave_Quantity_YGlobal)))*_Wave_Intensity_YGlobal*v.normal))*saturate((node_3934+node_3934)));
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : COLOR {
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
                i.normalDir = normalize(i.normalDir);
                i.normalDir *= faceSign;
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
////// Lighting:
////// Emissive:
                float3 emissive = lerp(_Color.rgb,_Fade.rgb,floor((distance(i.posWorld.rgb,_WorldSpaceCameraPos)/_Dist) * _Posterize) / (_Posterize - 1));
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
            uniform float _Wave_Intensity_U;
            uniform float _Wave_Speed_U;
            uniform float _Y_Global;
            uniform float _Wave_Quantity_YGlobal;
            uniform float _Wave_Intensity_YGlobal;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                V2F_SHADOW_CASTER;
                float2 uv0 : TEXCOORD1;
                float4 posWorld : TEXCOORD2;
                float3 normalDir : TEXCOORD3;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                float4 node_7242 = _Time + _TimeEditor;
                float node_6305 = o.uv0.r;
                float node_9419 = (1.0 - node_6305);
                float node_3934 = ((node_6305*node_6305)*(node_9419*node_9419));
                v.vertex.xyz += (((_Wave_Intensity_U*saturate(sin((((node_7242.g*_Wave_Speed_U)+(1.0 - node_6305))*_Wave_Quantity_U)))*v.normal)+(saturate(sin(((mul(unity_ObjectToWorld, v.vertex).g.r+(node_7242.g*_Y_Global))*_Wave_Quantity_YGlobal)))*_Wave_Intensity_YGlobal*v.normal))*saturate((node_3934+node_3934)));
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                TRANSFER_SHADOW_CASTER(o)
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : COLOR {
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
                i.normalDir = normalize(i.normalDir);
                i.normalDir *= faceSign;
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                SHADOW_CASTER_FRAGMENT(i)
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
