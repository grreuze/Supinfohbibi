// Shader created with Shader Forge v1.32 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.32;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:True,fnsp:False,fnfb:False;n:type:ShaderForge.SFN_Final,id:3138,x:32719,y:32712,varname:node_3138,prsc:2|emission-2348-OUT;n:type:ShaderForge.SFN_Color,id:7241,x:31660,y:32337,ptovrint:False,ptlb:Color_Near,ptin:_Color_Near,varname:node_7241,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:0,c3:0,c4:1;n:type:ShaderForge.SFN_FragmentPosition,id:9088,x:31329,y:32950,varname:node_9088,prsc:2;n:type:ShaderForge.SFN_Distance,id:4342,x:31556,y:32872,varname:node_4342,prsc:2|A-9088-XYZ,B-1715-XYZ;n:type:ShaderForge.SFN_Divide,id:850,x:31859,y:32887,varname:node_850,prsc:2|A-4342-OUT,B-1787-OUT;n:type:ShaderForge.SFN_ValueProperty,id:1787,x:31636,y:33068,ptovrint:False,ptlb:Dist,ptin:_Dist,varname:node_7184,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:10;n:type:ShaderForge.SFN_Lerp,id:2348,x:32369,y:32714,varname:node_2348,prsc:2|A-994-OUT,B-1614-RGB,T-8399-OUT;n:type:ShaderForge.SFN_Posterize,id:8399,x:32086,y:32887,varname:node_8399,prsc:2|IN-850-OUT,STPS-332-OUT;n:type:ShaderForge.SFN_ValueProperty,id:332,x:31869,y:33220,ptovrint:False,ptlb:Posterize,ptin:_Posterize,varname:node_9161,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:3;n:type:ShaderForge.SFN_ViewPosition,id:1715,x:31329,y:32813,varname:node_1715,prsc:2;n:type:ShaderForge.SFN_Color,id:1614,x:31941,y:32241,ptovrint:False,ptlb:Color_Fade,ptin:_Color_Fade,varname:_Color_Near_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0,c2:1,c3:0.1724138,c4:1;n:type:ShaderForge.SFN_Normalize,id:1831,x:31524,y:32694,varname:node_1831,prsc:2|IN-9088-XYZ;n:type:ShaderForge.SFN_ComponentMask,id:9507,x:31715,y:32684,varname:node_9507,prsc:2,cc1:1,cc2:-1,cc3:-1,cc4:-1|IN-1831-OUT;n:type:ShaderForge.SFN_Lerp,id:994,x:31957,y:32644,varname:node_994,prsc:2|A-7241-RGB,B-3574-OUT,T-9507-OUT;n:type:ShaderForge.SFN_Vector1,id:3574,x:31660,y:32547,varname:node_3574,prsc:2,v1:1;proporder:7241-1787-332-1614;pass:END;sub:END;*/

Shader "Shader Forge/fogobj" {
    Properties {
        _Color_Near ("Color_Near", Color) = (1,0,0,1)
        _Dist ("Dist", Float ) = 10
        _Posterize ("Posterize", Float ) = 3
        _Color_Fade ("Color_Fade", Color) = (0,1,0.1724138,1)
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
            uniform float4 _Color_Near;
            uniform float _Dist;
            uniform float _Posterize;
            uniform float4 _Color_Fade;
            struct VertexInput {
                float4 vertex : POSITION;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float4 posWorld : TEXCOORD0;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
////// Lighting:
////// Emissive:
                float node_3574 = 1.0;
                float3 emissive = lerp(lerp(_Color_Near.rgb,float3(node_3574,node_3574,node_3574),normalize(i.posWorld.rgb).g),_Color_Fade.rgb,floor((distance(i.posWorld.rgb,_WorldSpaceCameraPos)/_Dist) * _Posterize) / (_Posterize - 1));
                float3 finalColor = emissive;
                return fixed4(finalColor,1);
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
