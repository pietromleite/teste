# Estágio 1: Construir a aplicação
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src

# Copie apenas o arquivo do projeto para otimizar o cache
COPY teste.csproj .
RUN dotnet restore

# Copie o restante dos arquivos
COPY . .

# Construa o projeto
RUN dotnet build -c Release -o /app

# Estágio 2: Publicar a aplicação
FROM build AS publish
RUN dotnet publish -c Release -o /app

# Estágio 3: Criar imagem final
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS final
WORKDIR /app

# Copie os arquivos publicados
COPY --from=publish /app .

# Defina o ponto de entrada para a aplicação
ENTRYPOINT ["dotnet", "teste.dll"]
