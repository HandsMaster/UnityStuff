#version 330
attribute vec3 position;
attribute float red;
attribute float green;
attribute float blue;
attribute float alpha;
out vec4 vcolor;
void main() {
  gl_Position = vec4(position.x * 2 - 1, position.y * 2 - 1, position.z, 1);
  vcolor = vec4(red, green, blue, alpha);
}
