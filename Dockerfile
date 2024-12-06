FROM mono:latest
RUN apt-get update -y
RUN apt-get -y install sudo wget gnupg gnupg1 gnupg2 lsb-release software-properties-common
RUN wget -qO - https://packages.confluent.io/deb/7.3/archive.key | sudo apt-key add -
RUN sudo add-apt-repository "deb [arch=amd64] https://packages.confluent.io/deb/7.3 stable main"
RUN sudo add-apt-repository "deb https://packages.confluent.io/clients/deb $(lsb_release -cs) main"
RUN sudo apt-get update
RUN echo Y | apt install librdkafka-dev
RUN rm -rf /var/lib/apt/lists/*
RUN mkdir /opt/app
COPY . /opt/app
WORKDIR /opt/app
RUN mkdir /opt/app/data
RUN msbuild MealTimeMS.sln /property:Configuration=Release /property:Platform=x64 /property:DefineConstants="IGNORE" /restore
ENTRYPOINT ["mono","MealTimeMS/bin/x64/Release/MealTimeMS.exe"]
