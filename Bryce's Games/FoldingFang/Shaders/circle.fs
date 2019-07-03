#version 330
uniform vec2 pos;
uniform float radius;
uniform vec4 color;

void main(){
  float pct = length(pos - gl_FragCoord.xy) / radius;
	gl_FragColor = color;
}
