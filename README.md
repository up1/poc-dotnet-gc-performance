# poc-dotnet-gc-performance

### Step to run
```
$docker-compose build
$docker-compose up -d
$docker-compose ps
$docker-compose logs --follow
```

Build and run only api
```
$docker-compose stop api
$docker-compose rm api
$docker-compose build api
$docker-compose up -d api
$docker-compose ps
```

### Load testing 
```
$wrk -c 100 -t 5 -d 10s http://localhost:8000/weatherforecast
```

### Monitoring 
* [Grafana](http://localhost:3000/)
* [Prometheus](http://localhost:9090/)
