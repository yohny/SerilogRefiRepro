# Serilog Refit Repro

this is a repro project for showcasing the Serilog issue https://github.com/serilog/serilog/issues/1793

When launched go to https://localhost:7085/swagger/index.html - there are 2 endpoints exposed (one making external request using regular HttpClient, the other using Refit) - try them and observe the console log
