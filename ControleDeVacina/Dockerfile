FROM microsoft/aspnetcore:1.1
ARG source
WORKDIR /app
EXPOSE 80
EXPOSE 5000 
EXPOSE 1433 
COPY ${source:-obj/Docker/publish} .
ENTRYPOINT ["dotnet", "ControleDeVacina.dll"]
