#version 330
in vec3 vcolor;
out vec4 frag_color;
void main(void) {
  frag_color = vec4(vcolor, 1);
}