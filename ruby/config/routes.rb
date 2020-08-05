Rails.application.routes.draw do
  get 'flagr/health'
  get 'flagr/find_flags'
  get 'flagr/find_flag/:flag_id' => 'flagr#find_flag'

  root 'flagr#index'
  resources :todos do
    resources :items
  end
end