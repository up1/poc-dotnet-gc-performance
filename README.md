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


### Resources
* [Basic of GC in .Net](https://docs.microsoft.com/en-us/dotnet/standard/garbage-collection/fundamentals)
* [Redis library for .Net](https://docs.redis.com/latest/rs/references/client_references/client_csharp/)
   * https://github.com/StackExchange/StackExchange.Redis
   * [Basic usage](https://stackexchange.github.io/StackExchange.Redis/Basics)
   * [Configuration of Redis client](https://stackexchange.github.io/StackExchange.Redis/Configuration.html)
   * https://docs.microsoft.com/en-us/azure/azure-cache-for-redis/cache-dotnet-how-to-use-azure-redis-cache
* Prometheus for .Net
   * https://github.com/prometheus-net/prometheus-net
   * [Grafana dashboard](https://github.com/prometheus-net/grafana-dashboards)
