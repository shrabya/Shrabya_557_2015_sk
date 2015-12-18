#version 410 core

//  Shrabya kayastha

uniform sampler2D colorMap;
uniform sampler2D noiseMap;
uniform int blend;

in vec2 pass_TexCoord;
out vec4 color;

void main(void)
{
    vec2 noiseVec = normalize(texture(noiseMap, pass_TexCoord)).xy;
    //noiseVec = (noiseVec * 2.0 - 1.0) * 0.035;

    color = texture(colorMap, pass_TexCoord + noiseVec);
}
