FROM mcr.microsoft.com/dotnet/sdk:9.0-noble

RUN apt-get update -yq && \
    apt-get install -yq curl ca-certificates && \
    install -m 0755 -d /etc/apt/keyrings && \
    curl -fsSL https://download.docker.com/linux/ubuntu/gpg -o /etc/apt/keyrings/docker.asc && \
    echo "deb [arch=amd64 signed-by=/etc/apt/keyrings/docker.asc] https://download.docker.com/linux/ubuntu noble stable" > /etc/apt/sources.list.d/docker.list && \
    apt-get update -yq && \
    apt-get install -yq docker-ce-cli nodejs npm && \
    rm -rf /var/lib/apt/lists/* && \
    npm install -g create-react-app

RUN dotnet tool install --global dotnet-ef

WORKDIR /workspace
COPY . .