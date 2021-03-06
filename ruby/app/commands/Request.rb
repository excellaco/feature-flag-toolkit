class Request
  class << self
    def where(resource_path, query = {}, options = {})
      response, status = get_json(resource_path, query)
      status == 200 ? response : errors(response)
    end

    def get(id = nil)
      response, status = get_json(id)
      status == 200 ? response : errors(response)
    end

    def errors(response)
      error = { errors: { status: response["status"], message: response["message"] } }
      response.merge(error)
    end

    def get_json(root_path, query = {})
      query_string = query.map{|k,v| "#{k}=#{v}"}.join("&")
      path = query.empty?? root_path : "#{root_path}?#{query_string}"
      response = api.get(path)

      [JSON.parse(response.body), response.status]
    end

    def post(uri, params)
      body = params_to_json(params)
      api.post(uri, body)
    end

    def put(params)
      #args root_path, query = {}
      # byebug
      # query_string = query.map{|k,v| "#{k}=#{v}"}.join("&")
      # path = query.empty?? root_path : "#{root_path}?#{query_string}"
      # api.put(path)
      body = params_to_json(params)
      api.post("flags", body)
    end

    def api
      Connection.api
    end

    private
    def params_to_json(params)
      body = {
        description: params[:description],
        key: params[:key],
        template: params[:template],
        flag_id: params[:flag_id],
        enabled: params[:enabled],
        rolloutPercent: params[:rollout_percent]
      }.to_json

      body
    end
  end
end