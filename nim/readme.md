How to deploy NIM in 5 minutes 

Before you get started, make sure you have all the prerequisites. Follow the requirements in the NIM documentation. Note that an NVIDIA AI Enterprise License is required to download and use NIM.

When you have everything set up, run the following script:
    # Choose a container name for bookkeeping
    export CONTAINER_NAME=meta/llama3-8b-instruct
    
    # Choose a LLM NIM Image from NGC
    export IMG_NAME="nvcr.io/nim/${CONTAINER_NAME}:1.0.0"
    
    # Choose a path on your system to cache the downloaded models
    export LOCAL_NIM_CACHE="~/.cache/nim"
    mkdir -p "$LOCAL_NIM_CACHE"
    
    # Start the LLM NIM
    docker run -it --rm --name=$CONTAINER_NAME \
      --runtime=nvidia \
      --gpus all \
      -e NGC_API_KEY \
      -v "$LOCAL_NIM_CACHE:/opt/nim/.cache" \
      -u $(id -u) \
      -p 8000:8000 \
      $IMG_NAME