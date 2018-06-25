cmake_minimum_required(VERSION 3.0)
project(cpp-coreclr)

add_compile_options(-fPIE)

add_executable(main src/main.cpp)
target_link_libraries(main dl pthread)
